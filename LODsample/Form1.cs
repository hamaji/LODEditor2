﻿using System;
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
                    var serializer = new DataContractJsonSerializer(typeof(LOD));
                    //info = (LOD)serializer.ReadObject(resStream);
                    var obj = DynamicJson.Parse(resStream);
                    //var objj = from foo in obj["results"] where ;
                    foreach (var item in obj.results)
                    {
                        if (item.Key == "bindings")
                        {
                            foreach (var it in item.Value)
                            {

                                foreach(var val in it.o)
                                {
                                    if(val.Key == "value")
                                    {
                                        var o = val.Value;
                                    }
                                }
                                //if (it.Key == "p")
                                //{

                                    //var p = it.p;
                                    //var o = it.o;
                                //}
                                
                                //info = (LOD)serializer.ReadObject(o);
                            
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

            // 実際のSPARQLクエリ文。URLを打つのがめんどい場合はPREFIX使おう
        // 今回は関数の引数に実際の値となるもの（東京都とか岩手県とか）を渡す感じで
        // また、Abstractの項目の値のみを取得しています。全部取得する場合は?pとかで
        //var query = "select distinct * where {"+ " <" + "http://ja.dbpedia.org/resource/" +arg  +"> <"+"http://dbpedia.org/ontology/abstract> ?o . }";
            var query = "select distinct * where {" + " ?s <http://www.w3.org/2000/01/rdf-schema#label> ?o . }";
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

    }
}
