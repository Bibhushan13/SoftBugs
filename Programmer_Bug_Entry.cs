SqlCommand cmd = new SqlCommand();

                    //parameterized query
                    //anti-sql-injection
                    cmd.CommandText = "SELECT * FROM tblUsers WHERE userPosition=@userRole";

                    cmd.Connection = Conn;
                    cmd.Parameters.AddWithValue("@userRole", "Programmer");