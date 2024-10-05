using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using 에누링.ViewModel;
using 에누링.View;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using 에누링.Model;

namespace 에누링.ViewModel.Command
{
    class PageNavigateCommand : ICommand
    {
        PageNavigateVM VMRef { get; set; }

        public PageNavigateCommand(PageNavigateVM vm)
        {
            VMRef = vm;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        string conString = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=test.accdb";

        object runQueryResult(string Query)
        {
            object result = null;

            try
            {
                using (OleDbConnection con = new OleDbConnection())
                {
                    con.ConnectionString = conString;
                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            cmd.Connection = con;
                            cmd.CommandText = Query;

                            result = cmd.ExecuteScalar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }

        bool runQuery(string Query)
        {
            bool result = false;

            try
            {
                using (OleDbConnection con = new OleDbConnection())
                {
                    con.ConnectionString = conString;
                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            cmd.Connection = con;
                            cmd.CommandText = Query;

                            cmd.ExecuteNonQuery();
                            result = true;
                        }
                    }
                }
            }
            catch
            {
                result = false;
            }

            return result;

        }
        public void Execute(object parameter)
        {

            string direction = (string)parameter;
            if (direction == "Register")
            {
                VMRef.NavigateTo(VMRef.currentPage + 1);
            }
            else if (direction == "Join")
            {

                object result = runQueryResult(String.Format("select count(*) from user_login where ID = '{0}';", Model.DBdata_insert.MyID.Trim()));

                if (result != null)
                {
                    if ((int)result == 0)
                    {
                        runQuery(String.Format("INSERT INTO user_login (ID, PW, IRUM, HP) VALUES('{0}', '{1}', '{2}', '{3}');", Model.DBdata_insert.MyID.Trim(), Model.DBdata_insert.MyPw.Trim(), Model.DBdata_insert.MyNw.Trim(), Model.DBdata_insert.MyFw.Trim()));

                        result = runQueryResult(String.Format("select count(*) from user_login where ID = '{0}';", Model.DBdata_insert.MyID));
                        if (result != null)
                            if ((int)result > 0)
                            {
                                MessageBox.Show("등록되었습니다.");
                                VMRef.NavigateTo(VMRef.currentPage - 1);
                            }
                    }
                    else
                    {
                        MessageBox.Show("이미 등록된 ID 입니다.");
                    }
                }
                else
                {
                    MessageBox.Show("DB가 연결되지 않았습니다.");
                    VMRef.NavigateTo(VMRef.currentPage - 1);
                }
            }
            else if (direction == "Back")
            {
                VMRef.NavigateTo(VMRef.currentPage - 1);
            }
            else if (direction == "Login")
            {
                object result = runQueryResult(String.Format("select count(*) from user_login where ID = '{0}' and PW = '{1}';", Model.DBdata_insert.MyID.Trim(), Model.DBdata_insert.MyPw.Trim()));

                if (result != null)
                {
                    if ((int)result > 0)
                    {
                        MessageBox.Show("로그인 되었습니다.");
                        VMRef.NavigateTo(VMRef.currentPage + 2);
                    }
                    else
                    {
                        MessageBox.Show("ID 나 pw 틀렸습니다.");
                    }

                }
                else
                {
                    MessageBox.Show("DB 가 연결되지 않았습니다.");
                }
            }
            else if (direction == "Sell")
            {
                VMRef.NavigateTo(VMRef.currentPage + 1);
            }
            else if (direction == "Ok")
            {

                object result = runQueryResult(String.Format("select count(*) from user_login where ID = '{0}';", Model.DBdata_insert.MyID.Trim()));

                if (result != null)
                {

                    if (ViewModel.Command.Selectbutton.place == "")
                    {
                        MessageBox.Show("장소를 입력하세요.");
                    }
                    else if (View.Page1.quality == "" || View.Page1.open == "" || View.Page1.deal == "")
                    {
                        MessageBox.Show("체크박스를 확인하세요.");
                    }
                    else if (Model.DBdata_insert.MyExplan == "")
                    {
                        MessageBox.Show("물품설명을 입력하세요.");
                    }
                    else
                    {
                        runQuery(String.Format("insert into user_sell (id, price, deadline, explan, quality, openn, deal, place, pname) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');", Model.DBdata_insert.MyID.Trim(), Model.DBdata_insert.MyPrice, Model.DBdata_insert.date.ToString("yyyy-MM-dd"), Model.DBdata_insert.MyExplan.Trim(), View.Page1.quality, View.Page1.open, View.Page1.deal, ViewModel.Command.Selectbutton.place, Model.DBdata_insert.MyName.Trim()));

                        result = runQueryResult(String.Format("select count(*) from user_sell where ID = '{0}' AND explan='{1}';", Model.DBdata_insert.MyID, Model.DBdata_insert.MyExplan.Trim()));
                        if (result != null)
                            if ((int)result > 0)
                            {
                                MessageBox.Show("등록되었습니다.");
                                VMRef.NavigateTo(VMRef.currentPage - 1);
                            }
                    }
                }
            }
            else if (direction == "BUY")
            {
                DBdata dbdata = new DBdata();
                VMRef.NavigateTo(VMRef.currentPage + 2);
            }
            else if (direction == "Next")
            {

                VMRef.NavigateTo(VMRef.currentPage + 1);
            }
            else if (direction == "Next1")
            {

                VMRef.NavigateTo(VMRef.currentPage + 2);
            }
            else if (direction == "Next2")
            {
                VMRef.NavigateTo(VMRef.currentPage + 3);
            }
            else if (direction == "Back1")
            {
                VMRef.NavigateTo(VMRef.currentPage - 2);
            }

        }
        
    }
}
