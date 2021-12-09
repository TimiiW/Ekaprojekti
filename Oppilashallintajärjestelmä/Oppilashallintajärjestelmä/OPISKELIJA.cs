﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Oppilashallintajärjestelmä
{
    class OPISKELIJA
    {
        YHDISTA yhteys = new YHDISTA();

        public bool lisaaOpiskelia(String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlConnection komento = new MySqlConnection();
            String lisayskysely = "INSERT INTO yhteystiedot " +
                "(etunimi, sukunimi, puhelin, sahkoposti, opiskelianumero) " +
                "VALUES (@enm, @snm, @puh, @eml, @ono); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.VarChar).Value = onro;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonquery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public DataTable haeOpiskeliat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelianumero FROM yhteistiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool muokkaaOpiskelijaa(int oid,String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `yhteystiedot` SET `Etunimi` = @enm," +
                "`Sukunimi`= @snm, `puhelin`= @puh,`sahkoposti`= @eml,`opiskelianumero`= 2ono" +
                " WHERE oid = @oid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.VarChar).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.VarChar).Value = oid;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }

            public bool poistaOpiskelija(String ktunnus)
            {
                MySqlCommand komento = new MySqlCommmand();
                String poistokysely = "DELETE FROM yhteystiedot WHERE oid = @ktu";
                komento.CommandText = poistokysely;
                komento.Connection yhteys.otaYhteys();
                komento.Parameters.Add("@ktu", MySqlDbType.UInt32).Value = ktunnus;

                yhteys.avaaYhteys();
                if (komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return false;
                }
            }
        }
    }
}
