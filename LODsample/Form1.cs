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
            
            //エンドポイントのアクセス
            // HTTPアクセス
            var req = WebRequest.Create(url);
            req.Headers.Add("Accept-Language:ja,en-us;q=0.7,en;q=0.3");
            var res = req.GetResponse();
            //エンドポイントの構造の表示



        }

        private string URL作成()
        {
            var endpoint = txtEndpoint.Text;
            var arg = "東京都";
            var format = "text";

            // 実際のSPARQLクエリ文。URLを打つのがめんどい場合はPREFIX使おう
        // 今回は関数の引数に実際の値となるもの（東京都とか岩手県とか）を渡す感じで
        // また、Abstractの項目の値のみを取得しています。全部取得する場合は?pとかで
        var query = "select distinct * where {"+ " <" + "http://ja.dbpedia.org/resource/" +arg  +"> < "+"http://dbpedia.org/ontology/abstract> ?o . }";

        var urlen = System.Web.HttpUtility.UrlEncode(query);
            return endpoint + "query=" +urlen +"&format=" +format;
        }

    }
}
