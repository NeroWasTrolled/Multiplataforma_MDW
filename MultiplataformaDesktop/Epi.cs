using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplataformaDesktop
{
    public class Epi
    {
        public int id { get; set; }
        public string epi { get; set; }
        public DateTime validade { get; set; }

        MySqlConnection con = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm");
        public List<Epi> listaepi()
        {
            List<Epi> li = new List<Epi>();
            string sql = "SELECT * FROM epi";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Epi p = new Epi();
                p.id = (int)dr["id"];
                p.epi = dr["epi"].ToString();
                p.validade = DateTime.Parse(dr["validade"].ToString());
                li.Add(p);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string epi, DateTime validade)
        {
            string sql = "INSERT INTO epi(epi,validade) VALUES ('" + epi + "','" + validade + "')";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Atualizar(int id, string epi, DateTime validade)
        {
            string sql = "UPDATE epi SET epi='" + epi + "',validade='" + validade + "' WHERE id='" + id + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Excluir(int id)
        {
            string sql = "DELETE FROM epi WHERE id='" + id + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localizar(int id)
        {
            string sql = "SELECT * FROM epi WHERE id='" + id + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                epi = dr["nome"].ToString();
                validade = DateTime.Parse(dr["validade"].ToString());
            }
            dr.Close();
            con.Close();
        }

        public bool RegistroRepetido(string epi, DateTime validade)
        {
            string sql = "SELECT * FROM epi WHERE epi='" + epi + "' AND validade='" + validade + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteNonQuery();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }
    }
}

