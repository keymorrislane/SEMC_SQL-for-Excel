using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;

namespace SSEBasicVersion
{
    public partial class Settings : Form
    {
        static private string[] columnName = new string[]{"日期","时间","业务楼室外湿度","业务楼室外温度",
            "3F 生物降解室温度","3F 生物降解室湿度","3F 藻类毒性实验室温度","3F 藻类毒性实验室湿度",
            "3F 生态模拟实验室温度","3F 生态模拟实验室湿度","3F 常用试剂储存室温度",
            "3F 常用试剂储存室湿度","3F 鱼类繁殖驯养室温度","3F 鱼类繁殖驯养室湿度",
            "3F 活性污泥培养室温度","3F 活性污泥培养室湿度","4F 无菌室温度","4F 无菌室湿度",
            "4F 培养室温度","4F 培养室湿度","5F 性能指标考核实验室温度","5F 性能指标考核实验室湿度",
            "5F 臭氧标准实验室温度","5F 臭氧标准实验室湿度","5F 大气准备室温度",
            "5F 大气准备室湿度","8F BOD室温度","8F BOD室湿度","8F COD室温度","8F COD室湿度",
            "8F 天平室温度","8F 天平室湿度","9F 天平室温度","9F 天平室湿度","9F 分光光度计室温度",
            "9F 分光光度计室湿度","实验楼室外温度","实验楼室外湿度"};
        public Settings()
        {
            InitializeComponent();
            string today = System.DateTime.Today.ToString("yyyy_MM_dd");
            BeginYear.Maximum = int.Parse(today.Split('_')[0]);
            EndYear.Maximum = BeginYear.Maximum;
            BeginYear.Value = int.Parse(today.Split('_')[0]);
            BeginMonth.Value = int.Parse(today.Split('_')[1]);
            BeginDay.Value = int.Parse(today.Split('_')[2]);
            EndYear.Value = BeginYear.Value;
            EndMonth.Value = BeginMonth.Value;
            EndDay.Value = BeginDay.Value;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainRibbon.connectionHandle.Close();
            MainRibbon.connectionHandle.Dispose();
            ActiveForm.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (BeginYear.Value > EndYear.Value)
            {
                MessageBox.Show("结束日期早于起始日期，请重新选择。");
                return;
            }
            else if (BeginYear.Value == EndYear.Value && 
                BeginMonth.Value > EndMonth.Value)
            {
                MessageBox.Show("结束日期早于起始日期，请重新选择。");
                return;
            }
            else if (BeginYear.Value == EndYear.Value && 
                BeginMonth.Value == EndMonth.Value && 
                BeginDay.Value > EndDay.Value)
            {
                MessageBox.Show("结束日期早于起始日期，请重新选择。");
                return;
            }
            ActiveForm.Close();
            ImportMsg importMsg = new ImportMsg();
            importMsg.text.Text = "正在导入，请稍候。";
            importMsg.Show();
            string tableHead = "temperature_humidity_", tableName = "", cmdString = "", date = "";
            //表名固定字串，表名，MySQL命令，日期。
            Microsoft.Office.Interop.Excel.Application excel = 
                new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Worksheet activeWorksheet =
                (Worksheet)Globals.SSEBasicVersionAddIn.Application.ActiveWorkbook.ActiveSheet;
            for (int col = 1; col <= 38; col++)
            {
                activeWorksheet.Cells[1, col].Value = columnName[col-1];//#IMPORTANT:写表
            }
            activeWorksheet.get_Range("A1", "AL1").WrapText = true;
            for(int year = Convert.ToInt32(BeginYear.Value); 
                year <= Convert.ToInt32(EndYear.Value); 
                year++)
                {
                    int month = 1;
                    if (year == Convert.ToInt32(BeginYear.Value))
                    {
                        month = Convert.ToInt32(BeginMonth.Value);
                    }
                while (month <= Convert.ToInt32(EndMonth.Value) ||
                    (year < Convert.ToInt32(EndYear.Value) && month <= 12))
                {
                    //若年份在区间中段，循环1至12月，若年份在区间端点，边界设为端点值。
                    int day = 1;
                    if (month == Convert.ToInt32(BeginMonth.Value))
                    {
                        day = Convert.ToInt32(BeginDay.Value);
                    }
                    while(day <= Convert.ToInt32(EndDay.Value) || 
                        (month != Convert.ToInt32(EndMonth.Value) && day <= 31))
                    {
                        //若月份在区间中段，循环1至31天，无表天数无数据。若月份在端点，边界设为端点值。
                        if (!DateLegal(year, month, day))
                        {
                            //日期非法，跳出本月。
                            break;
                        }
                        //日期检查结束，开始执行数据库操作。
                        tableName = tableHead + year.ToString() + "_" + 
                            month.ToString() + "_" + day.ToString();//生成表名
                        date = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
                        activeWorksheet.Cells[activeWorksheet.UsedRange.Rows.Count + 1, 1].Value = date;//#IMPORTANT:写表
                        day++;//day使用完毕，自增1天。
                        bool exsisted = true;//表是否存在。
                        cmdString = "select * from " + tableName + ";";
                        try
                        {//检查当日数据表是否存在。
                            MySqlCommand existCMD = new MySqlCommand(
                                cmdString, MainRibbon.connectionHandle);
                            existCMD.ExecuteNonQuery();
                            existCMD.Dispose();
                        }
                        catch (MySqlException ex)
                        {//抛出异常，表不存在。
                            exsisted = false;
                        }
                        if (!exsisted)
                        {//不存在记录，找下一天。
                            continue;
                        }
                        else
                        {//当天记录表存在，进行导入。
                            MySqlDataAdapter adapter = new MySqlDataAdapter(
                                cmdString, MainRibbon.connectionHandle);
                            DataSet dataSet = new DataSet();
                            System.Data.DataTable dataTable = new System.Data.DataTable();
                            adapter.Fill(dataSet);
                            dataTable = dataSet.Tables[0];//整表导出
                            DataView dataView = dataTable.DefaultView;
                            dataView.Sort = "time";
                            dataTable = dataView.ToTable();
                            int pointNum = dataTable.Rows.Count;//当日总记录条数
                            int cursor, flag;
                            string time = "";
                            for (flag = 0; flag < pointNum; flag++)//寻找第一个非0记录
                            {
                                if (dataTable.Rows[flag].ItemArray[0].ToString() != "0")
                                {//找到非0记录，记录第一个时间。
                                    time = dataTable.Rows[flag].ItemArray[0].ToString().Split('_')[1];
                                    break;
                                }
                            }
                            cursor = flag;//初始化游标
                            int row = activeWorksheet.UsedRange.Rows.Count;
                            int startRow = row;
                            string colName = "", cursorName = "";//表点位名称，游标点位名称
                            while (flag < pointNum)
                            {
                                if (dataTable.Rows[flag].ItemArray[0].ToString() != "0")
                                {
                                    string nextTime = dataTable.Rows[flag].ItemArray[0].ToString().Split('_')[1];
                                    //寻找下一个时间点起始位置。
                                    if (nextTime != time && nextTime != "0")
                                    {//找到边界，记录时间，开始在本区间内查找对应值。
                                        //如果一个时间点上同一监测点位存在重复值，则取第一个值
                                        time = nextTime;
                                        activeWorksheet.Rows.Cells[row, 2].Value = time;//#IMPORTANT:写表
                                        for (int col = 3; col <= 38; col++)
                                        {//按列查找
                                            colName = activeWorksheet.Rows.Cells[1, col].Value;
                                            while (cursor < flag)
                                            {
                                                cursorName = dataTable.Rows[cursor].ItemArray[1].ToString();//当前游标点位名称
                                                cursor++;
                                                if (Equals(cursorName, colName))
                                                {//点位名称对应，则导入数据
                                                    activeWorksheet.Rows.Cells[row, col].Value =
                                                        dataTable.Rows[cursor].ItemArray[2];//#IMPORTANT:写表
                                                    break;
                                                }
                                            }
                                        }
                                        cursor = flag;//游标置为下一时间点
                                        row++;//excel行数增加
                                    }
                                    else
                                    {
                                        flag++;
                                    }
                                }
                            }
                            //释放。
                            activeWorksheet.get_Range("A" + startRow.ToString(), "A" + 
                                (activeWorksheet.UsedRange.Rows.Count).ToString()).Merge();//合并单元格
                            adapter.Dispose();
                            dataSet.Dispose();
                            dataTable.Dispose();
                        }
                    }
                    month++;
                }
            }
            importMsg.Close();
            importMsg.Dispose();
        }

        private bool DateLegal(int year, int month, int day)
        {//判断时间合法性。
            if (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day >= 31)
                {
                    return false;
                }
            }
            if (month == 2)
            {
                if ((year % 100 != 0 && year % 4 != 0) || (year % 100 == 0 && year % 400 != 0))
                {
                    //若为平年。
                    if (day >= 29)
                    {
                        return false;
                    }
                }
                else
                {
                    //若为闰年。
                    if (day >= 30)
                        return false;
                }
            }
            return true;
        }
    }
}

//try
//{
//    MySqlDataAdapter adapter = new MySqlDataAdapter(
//    cmdString, MainRibbon.connectionHandle);
//    DataSet dataSet = new DataSet();
//    System.Data.DataTable dataTable = new System.Data.DataTable();
//    adapter.Fill(dataSet);
//    dataTable = dataSet.Tables[0];
//    pointNum = dataTable.Rows.Count / 38;
//    //单个时间点共有38个监测点位，pointNum表示时间点数。
//    int row = maxRow + 1, dataTableRow;
//    dataTableRow = row;
//    while(dataTableRow - maxRow < pointNum)
//    {
//        try
//        {
//            //第2列，填入时间点，原始MySQL数据中格式为年-月-日_时-分，以下划线"_"分割。
//            activeWorksheet.Cells[row, 2].Value =
//            dataTable.Rows[(dataTableRow - maxRow - 1) * 38].ItemArray[0].ToString().Split('_')[1];
//            for (int col = 3; col <= 41; col++)
//            {
//                for(int )
//                activeWorksheet.Cells[row, col].Value =
//                dataTable.Rows[(dataTableRow - maxRow - 1) * 38 + col - 3].ItemArray[2];
//                //第3至第31列，填入38个点位的数据。
//            }
//            row++;
//        }
//        catch (Exception ex)
//        {
//            //跳过零数据。
//            continue;
//        }
//        finally
//        {
//            dataTableRow++;
//        }
//    }
//    activeWorksheet.get_Range("A" + (maxRow + 1).ToString(), "A" + (row - 1).ToString()).Merge();
//}
//catch (MySqlException ex)
//{

//}
//finally
//{
//    day++;
//    importMsg.Close();
//    importMsg.Dispose();
//}