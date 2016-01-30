private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblUsers (userName, userEmail, userPassword, userMobile, userPosition) Values (@txtUsername,@txtEmail,@txtPassword,@txtMobile,@cmbb2)"; // Use a parameterized query to avoid SQL Injection
            cmd.Connection = Conn;
            cmd.Parameters.AddWithValue("@txtUsername", txtUsername.Text);
            cmd.Parameters.AddWithValue("@txtEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@txtPassword", txtPassword.Text);
            cmd.Parameters.AddWithValue("@txtMobile", txtMobile.Text);
            cmd.Parameters.AddWithValue("@cmbb2", cmbb2.Text);
            
            // Use a try... catch...finally block to ensure the connection is closed properly
            try
            {
                Conn.Open();
                cmd.ExecuteNonQuery();
                lblStatus.Text = "Item Inserted";
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.ToString();
            }
            finally
            {
                Conn.Close(); // will happen whether the try is successful or errors out, ensuring your connection is closed properly.
            }
        }