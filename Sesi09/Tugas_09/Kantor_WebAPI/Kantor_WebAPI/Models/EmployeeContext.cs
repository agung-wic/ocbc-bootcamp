﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Kantor_WebAPI.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }

        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat"),
                        });
                    }
                }
            }
            return list;
        }

        public string PostEmployeeItem (EmployeeItem employee)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into employee(nama, jenis_kelamin, alamat) values(@nama, @jenisKelamin, @alamat)", conn))
                {
                    cmd.Parameters.AddWithValue("@nama", employee.nama);
                    cmd.Parameters.AddWithValue("@jenisKelamin", employee.jenisKelamin);
                    cmd.Parameters.AddWithValue("@alamat", employee.alamat);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "success";
        }

        public string UpdateEmployeeItem(int id, EmployeeItem employee)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("update employee set nama=@nama, jenis_kelamin=@jenisKelamin, alamat=@alamat where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@nama", employee.nama);
                    cmd.Parameters.AddWithValue("@jenisKelamin", employee.jenisKelamin);
                    cmd.Parameters.AddWithValue("@alamat", employee.alamat);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "success";
        }

        public string DeleteEmployeeItem(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from employee where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "success";
        }

        public List<EmployeeItem> GetEmployee(int id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id =@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat"),
                        });
                    }
                }
            }
            return list;
        }
    }
}
