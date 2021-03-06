﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;

namespace ProdajaNekretnina
{
    public partial class Iznajmljivanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                zadnjeDodani.DataSource = DANekretnine.getZadnjeDodaneIzanjmljivanje();
                zadnjeDodani.DataBind();

                BindForm();
            }
        }

        private void BindForm()
        {
            ddlKategorije.DataSource = DANekretnine.getkategorije();
            ddlKategorije.DataTextField = "NazivKategorije";
            ddlKategorije.DataValueField = "KategorijaID";
            ddlKategorije.DataBind();

            ddlStanje.DataSource = DANekretnine.getSatanja();
            ddlStanje.DataTextField = "NazivStanja";
            ddlStanje.DataValueField = "StanjeID";
            ddlStanje.DataBind();

            ddlKantoni.DataSource = DANekretnine.getKantone();
            ddlKantoni.DataTextField = "Naziv";
            ddlKantoni.DataValueField = "KantonID";
            ddlKantoni.DataBind();

        }

        //protected void ddlKantoni_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int ID = Convert.ToInt32(ddlKantoni.SelectedValue);

        //    Kantoni k = DANekretnine.getKantoniByID(ID);

        //    if (k != null)
        //    {
        //        ddlGrad.DataSource = DANekretnine.getGradove(k.KantonID);
        //        ddlGrad.DataTextField = "NazivGarda";
        //        ddlGrad.DataValueField = "GradID";
        //        ddlGrad.DataBind();
        //    }
        //}

        protected void btnTrazi_Click(object sender, EventArgs e)
        {
            zadnjeDodani.DataSource = DANekretnine.getIznajmljivanje( Convert.ToInt32(ddlKantoni.SelectedValue), Convert.ToInt32(ddlKategorije.SelectedValue),
                Convert.ToInt32(ddlStanje.SelectedValue), Convert.ToDouble(tbCijena.Text), Convert.ToDouble(tbCiejnaDO.Text));
            zadnjeDodani.DataBind();

            clearSelection();
        }

        private void clearSelection()
        {
            ddlKategorije.SelectedIndex = 0;
           // ddlGrad.SelectedIndex = 0;
            ddlKantoni.SelectedIndex = 0;
            ddlStanje.SelectedIndex = 0;
            tbCiejnaDO.Text = "";
            tbCijena.Text = "";

        }
    }
}