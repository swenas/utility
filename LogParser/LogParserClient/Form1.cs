using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogParserClient {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnParse_Click( object sender, EventArgs e ) {
            if (String.IsNullOrEmpty( tbFilePath.Text )) {
                MessageBox.Show( "file path is required." );
                return;
            }

            if (String.IsNullOrEmpty( tbStringToFind.Text )) {
                MessageBox.Show( "string to find is required." );
                return;
            }

            if (String.IsNullOrEmpty( tbEnvironment.Text )) {
                MessageBox.Show( "environment is required." );
                return;
            }

            if (!File.Exists( tbFilePath.Text )) {
                MessageBox.Show( "File: " + tbFilePath.Text + " does not exist. " );
                return;
            }

            List<KeyValuePair<string, string>> propertyTransIdList = new List<KeyValuePair<string, string>>();
            using (StreamReader sr = new StreamReader( File.Open( tbFilePath.Text, FileMode.Open ) )) {

                while (sr.Peek( ) >= 0) {
                    var text = sr.ReadLine( );
                    var splitText = text.Split( '|' );
                    if (splitText != null && splitText.Length > 1) {
                        propertyTransIdList.Add( new KeyValuePair<string, string>( splitText[0], splitText[1] ) );
                    }
                }
            }

            rtbResults.Text = "There are: " + propertyTransIdList.Count + " to look for.\n";

            ProcessPropertyTransIdList( propertyTransIdList );
            //Task.Run( () => ProcessPropertyTransIdList( propertyTransIdList ));
            //task.Wait( );

            rtbResults.Text += "Done.\n";
        }

        private void ProcessPropertyTransIdList( List<KeyValuePair<string, string>> propertyTransIdList ) {
            foreach (var propertyTransId in propertyTransIdList) {
                string url = "https://" + tbEnvironment.Text + "/get/getintrlogitem.aspx?property=" + propertyTransId.Key + "&entity=REDROOF&intruid=" + propertyTransId.Value;
                string getIpRegex = @"(?<=<TITLE>.*)\d*\.\d*\.\d*\.\d*(?=</TITLE>)";
                System.Net.WebClient wc = new System.Net.WebClient( );
                System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding( );
                string requestHtml = "";

                try {
                    requestHtml = utf8.GetString( wc.DownloadData( url ) );
                    if (!String.IsNullOrEmpty( requestHtml )) {
                        requestHtml = requestHtml.Trim( new char[3] {' ', '\r', '\n'} );
                        if (requestHtml.Contains( tbStringToFind.Text )) {
                            var startIndex = requestHtml.IndexOf( "<pl_c6>" );
                            rtbResults.Text += requestHtml.Substring(startIndex, 69) + ", id=" + propertyTransId.Value +"\n";
                        }
                    }
                } catch (System.Net.WebException we) {
                    // do something with exception
                    System.Diagnostics.Debug.WriteLine( we.ToString( ) );
                } catch (Exception ex) {
                    // do something with exception
                    System.Diagnostics.Debug.WriteLine( ex.ToString( ) );
                }
            }
        }

        private void ClearResultsBox( ) {
            rtbResults.Clear(  );
        }
    }
}
