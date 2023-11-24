using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace primeraAplicacionFormularios.Models
{
     class Estudiante
    {
        public int idEstudiante { get; set; }
        public string  nombreEstudiante { get; set; }
        public string carnet { get; set; }

        public string direccion { get; set; }

        public string rutaConexion { get; set; }

        public Estudiante()
        {
            rutaConexion = @"Data Source=C:\Users\Javier\Desktop\bases\estudiantes.db";
            
        }

        public List<Estudiante> getStudiante() {

            List<Estudiante> lista = new List<Estudiante>();

            using (SqliteConnection connection = new SqliteConnection(this.rutaConexion))
            {
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                connection.Open();
                String consultaDatos = "SELECT * FROM tbl_estudiante";

                using (SqliteCommand command2 = new SqliteCommand(consultaDatos, connection))
                {

                    using (SqliteDataReader reader = command2.ExecuteReader())
                    {
                        //VERIFICAMOS SI TIENE FILAS LA CONSULTA
                        if (reader.HasRows)
                        {

                            //RECORREMOS LAS FILAS
                            while (reader.Read())
                            {
                                String nombreTemp = reader.GetString(reader.GetOrdinal("nombreEstudiante"));
                                Console.WriteLine($"Nombre estudiante {nombreTemp}");
                                Estudiante estudiante = new Estudiante();
                                estudiante.idEstudiante = reader.GetInt32(reader.GetOrdinal("idEstudiantes"));
                                estudiante.nombreEstudiante = reader.GetString(reader.GetOrdinal("nombreEstudiante"));
                                estudiante.carnet = reader.GetString(reader.GetOrdinal("carnet"));
                                estudiante.direccion = reader.GetString(reader.GetOrdinal("direccion"));
                                lista.Add(estudiante);
                            }

                        }
                    }

                }
                connection.Close();
            }

            return lista;
        }

        public void insertarDatos(Estudiante estudianteInsert) {

            using (SqliteConnection connection = new SqliteConnection(this.rutaConexion))
            {
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                connection.Open();
                String consultaInsert = "INSERT INTO tbl_estudiante(nombreEstudiante, carnet, direccion) VALUES(@nombre, @carnet, @dir);";
                using (SqliteCommand command = new SqliteCommand(consultaInsert, connection))
                {
                    command.Parameters.AddWithValue("@nombre", estudianteInsert.nombreEstudiante);
                    command.Parameters.AddWithValue("@carnet", estudianteInsert.carnet);
                    command.Parameters.AddWithValue("@dir", estudianteInsert.direccion);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Datos insertados");
                }

               

                connection.Close();
            }

        }
    }
}
