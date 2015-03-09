using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Codeplex.Data;


namespace LODsample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtEndpoint.Text = "http://ja.dbpedia.org/sparql?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //エンドポイントURL作成
            var url = URL作成();
            //var url = "http://ja.dbpedia.org/sparql?query=select+distinct+*+where+%7B+%3Chttp%3A%2F%2Fja.dbpedia.org%2Fresource%2F%E6%9D%B1%E4%BA%AC%E9%83%BD%3E+%3Fp+%3Fo+.+%7D&format=json%2Fhtml&timeout=0&debug=on";
            
            //エンドポイントのアクセス
            // HTTPアクセス
            var req = WebRequest.Create(url);
            req.Headers.Add("Accept-Language:ja,en-us;q=0.7,en;q=0.3");
            var res = req.GetResponse();
            //エンドポイントの構造の表示

            LOD info;
            using (res)
            {
                using (var resStream = res.GetResponseStream())
                {
                    var pList = new List<string>();
                    var serializer = new DataContractJsonSerializer(typeof(LOD));
                    //info = (LOD)serializer.ReadObject(resStream);
                    var obj = DynamicJson.Parse(resStream);
                    //var objj = from foo in obj["results"] where ;
                     foreach (var result in obj.results)
                    {
                        if (result.Key == "bindings")
                        {
                            foreach (var it in result.Value)
                            {
                                var label = "";
                                var o = "";
                                foreach(var val in it.label)
                                {
                                    if(val.Key == "value")
                                    {
                                        //pList.Add( val.Value);
                                        //dataGridView1.Rows.Add(val.Value,"作成");
                                        label = val.Value;
                                    }
                                }

                                foreach (var val in it.o)
                                {
                                    if (val.Key == "value")
                                    {
                                        //pList.Add( val.Value);
                                        //dataGridView1.Rows.Add(val.Value, "作成");
                                        o = val.Value;
                                    }
                                }

                                dataGridView1.Rows.Add(label,o, "作成");
                            
                            }
                        }
                    }
                }
            } 

            


        }

        private string URL作成()
        {
            var endpoint = txtEndpoint.Text;
            var arg = "東京都";
            var format = "json";

        //var query = "select distinct * where {"+ " <" + "http://ja.dbpedia.org/resource/" +arg  +"> <"+"http://dbpedia.org/ontology/abstract> ?o . }";
            var query = "select distinct ?o ?label where { ?s"+ "<" +"http://www.w3.org/1999/02/22-rdf-syntax-ns#type> ?o .?o   <http://www.w3.org/2000/01/rdf-schema#label> ?label . FILTER ( lang(?label) = \"ja\") }";
        var urlen = System.Web.HttpUtility.UrlEncode(query);
            return endpoint + "query=" +urlen +"&format=" +format;
        }

        [DataContract]
        public class LOD
        {
            [DataMember]
            public string s { get; set; }
            [DataMember]
            public string p { get; set; }
            [DataMember]
            public string o { get; set; }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ボタン列かどうかを確認 
            if (e.ColumnIndex == 1)
            {
                string property = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                var query = "select distinct * where {" + " ?s  <"+property+"> ?o . }";
                richTextBox1.Text = query;



                
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            var endpoint = txtEndpoint.Text;
            var format = "json";

            var urlen = System.Web.HttpUtility.UrlEncode(richTextBox1.Text);
            var url = endpoint + "query=" + urlen + "&format=" + format;

            //エンドポイントのアクセス
            // HTTPアクセス
            var req = WebRequest.Create(url);
            req.Headers.Add("Accept-Language:ja,en-us;q=0.7,en;q=0.3");
            var res = req.GetResponse();


            using (res)
            {
                using (var resStream = res.GetResponseStream())
                {
                    var pList = new List<string>();
                    var serializer = new DataContractJsonSerializer(typeof(LOD));
                    //info = (LOD)serializer.ReadObject(resStream);
                    var obj = DynamicJson.Parse(resStream);
                    
                    foreach (var result in obj.results)
                    {
                        if (result.Key == "bindings")
                        {
                            foreach (var it in result.Value)
                            {

                                string s = string.Empty;
                                string p = string.Empty;
                                string o = string.Empty;

                                foreach (var val in it.s)
                                {
                                    if (val.Key == "value")
                                    {
                                        s = val.Value;
                                       
                                    }
                                }

                                foreach (var val in it.o)
                                {
                                    if (val.Key == "value")
                                    {
                                        o = val.Value;
                                       
                                    }
                                }

                                dataGridView2.Rows.Add(s,p,o);

                            }
                        }
                    }
                }
            }
        }


    }
}
