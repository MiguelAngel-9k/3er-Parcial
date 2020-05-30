using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;

namespace _3erParcial
{
    class EnlaceCassandra
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        private static void conect()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }

        private static void disconect()
        {
            _cluster.Dispose();
        }

        public void insertData(city data)
        {
            try
            {
                conect();

                string characteristics;

                int index = 0;

                if (data.characteritics.Count > 0 && data.capital != "")
                {
                    characteristics = "[";
                    while ((data.characteritics.Count - 1) > index)
                    {
                        characteristics += "'" + data.characteritics[index] + "',";
                        index++;
                    }
                    characteristics += "'" + data.characteritics[index] + "']";
                }
                else characteristics="['NO-DATA']";



                string query = "INSERT INTO cities_by_id (" +
                        "id_city," +
                        "capital," +
                        "characteristics," +
                        "date," +
                        "hospital_quantity," +
                        "mayor," +
                        "population) VALUES(";

                    query += data.id.ToString() + ",'";
                    query += data.capital + "',";
                    query += characteristics + ",";
                    query += "toTimeStamp(toDate(now())),";
                    query += data.hostpital_quantity.ToString() + ",'";
                    query += data.mayor + "',";
                    query += data.population.ToString() + ");";

                    _session.Execute(query);
                    MessageBox.Show("Informacion agregada");
                return;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                disconect();
            }
        }

        public void insertColumn(string column)
        {
            try
            {
                conect();
                string query = "ALTER TABLE cities_by_id ADD " + column + ";";

                _session.Execute(query);
                disconect();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                disconect();
            }
        }

        public List<city> Get_Cities_by_id()
        {
            List<city> cities_list = new List<city>();

            try
            {
                string query = "SELECT id_city, capital , capital, mayor, hospital_quantity FROM cities_by_id;";
                conect();
                var data = _session.Execute(query);
                int id;
                string capital;
                foreach (var row in data)
                {
                    city tempCity = new city();
                    tempCity.id = row.GetValue<int>("id_city");
                    tempCity.capital = row.GetValue<string>("capital");
                    tempCity.mayor = row.GetValue<string>("mayor");
                    tempCity.hostpital_quantity = row.GetValue<int>("hospital_quantity");
                    cities_list.Add(tempCity);

                }
                disconect();
                return cities_list;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                disconect();
            }
        }

        public void Edit_characteristics(city data)
        {
            try
            {
                conect();
                string query = "UPDATE cities_by_id SET characteristics = ";
                string characteristics = "['";
                int i = 0;
                while ((data.characteritics.Count - 1) > i)
                {
                    characteristics += data.characteritics[i] + "','";
                    i++;
                }

                characteristics += data.characteritics[i] + "'] + characteristics  ";
                query += characteristics + "WHERE id_city = ";
                query += data.id.ToString() + " AND capital = '";
                query += data.capital + "';";
                _session.Execute(query);
                disconect();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                disconect();
            }


        }

        public void delte_row(city row)
        {
            conect();
            string query = "DELETE FROM cities_by_id WHERE id_city =";
            query += row.id.ToString() + ";";
            _session.Execute(query);
            disconect();
        }

        public void update(string query)
        {
            conect();
            _session.Execute(query);
            disconect();
        }

        public void deleteSingle(string query)
        {
            conect();
            _session.Execute(query);
            disconect();
        }
        public void replace(city newData, string id)
        {
            conect();
            int index = 0;
            string characteristics;

            if (newData.characteritics.Count > 0 && newData.capital != "")
            {

                characteristics = "[";
                while ((newData.characteritics.Count - 1) > index)
                {
                    characteristics += "'" + newData.characteritics[index] + "',";
                    index++;
                }
                characteristics += "'" + newData.characteritics[index] + "']";
            }
            else characteristics = "['NO-DATA']";

            string query = "BEGIN BATCH DELETE FROM cities_by_id WHERE id_city = ";
            query += id;
            query += " INSERT INTO cities_by_id (" +
                   "id_city," +
                   "capital," +
                   "characteristics," +
                   "date," +
                   "hospital_quantity," +
                   "mayor," +
                   "population) VALUES(";

            index = 0;                    

                query += newData.id.ToString() + ",'";
                query += newData.capital + "',";
                query += characteristics + ",";
                query += "toTimeStamp(toDate(now())),";
                query += newData.hostpital_quantity.ToString() + ",'";
                query += newData.mayor + "',";
                query += newData.population.ToString() + ") ";

                query += "APPLY BATCH;";

                _session.Execute(query);
                disconect();
 

        }

        public List<city> Get_All()
        {
            List<city> cities_list = new List<city>();

            try
            {
                string query = "SELECT id_city, capital ,date, mayor, hospital_quantity, population FROM cities_by_id;";
                conect();
                var data = _session.Execute(query);
                int id;
                string capital;
                foreach (var row in data)
                {
                    city tempCity = new city();
                    tempCity.id = row.GetValue<int>("id_city");
                    tempCity.capital = row.GetValue<string>("capital");
                    tempCity.mayor = row.GetValue<string>("mayor");
                    tempCity.hostpital_quantity = row.GetValue<int>("hospital_quantity");
                    tempCity.population = row.GetValue<int>("population");
                    tempCity.dateTime = row.GetValue<DateTime>("date");
                    cities_list.Add(tempCity);

                }
                disconect();
                return cities_list;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                disconect();
            }
        }
    }
}
