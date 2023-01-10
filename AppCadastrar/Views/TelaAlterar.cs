using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Controlador;
using Funcionario;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace AppCadastrar.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class TelaAlterar : AppCompatActivity
    {
        EditText nome;
        EditText cracha;
        EditText setor;
        EditText cargo;
        Button buscar;
        Button alterar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.TelaAlterar);

            nome = FindViewById<EditText>(Resource.Id.textNome);
            cracha = FindViewById<EditText>(Resource.Id.textCracha);
            setor = FindViewById<EditText>(Resource.Id.textSetor);
            cargo = FindViewById<EditText>(Resource.Id.textCargo);
            buscar = FindViewById<Button>(Resource.Id.btnBuscar);
            alterar = FindViewById<Button>(Resource.Id.btnAlterar);

            // Create your application here

            buscar.Click += delegate
            {
                search();
            };

            alterar.Click += delegate
            {
                alter();
            };
        }
        private void search()
        {
            if (cracha.Text != "")
            {
                bool retorno = controlador.searchCracha(int.Parse(cracha.Text));

                if (retorno == true)
                {
                    Toast.MakeText(this, "Registro encontrado", ToastLength.Short).Show();
                    nome.Text = controlador.getNome();
                    nome.Enabled = true;
                    cracha.Text = controlador.getCracha().ToString();
                    cracha.Enabled = true;
                    setor.Text = controlador.getSetor();
                    setor.Enabled = true;
                    cargo.Text = controlador.getCargo();
                    cargo.Enabled = true;
                }
                else
                {
                    Toast.MakeText(this, "Registro inexistente", ToastLength.Short).Show();
                }
            }
        }
        private void alter()
        {
            if (cracha.Text == "" && nome.Text == "" && setor.Text == "" && cargo.Text == "")
            {
                Toast.MakeText(this, "Sem dados para alterar", ToastLength.Short).Show();
            }
            else
            {
                mdlFuncionario mdlFuncionario = new mdlFuncionario(cracha.Text, nome.Text.ToUpper(), setor.Text.ToUpper(), cargo.Text.ToUpper());
                bool retorno = controlador.alter(mdlFuncionario);
                if (retorno == true)
                {
                    Toast.MakeText(this, "Registro alterado", ToastLength.Short).Show();
                    cracha.Text = String.Empty;
                    nome.Text = String.Empty;
                    setor.Text = String.Empty;
                    cargo.Text = String.Empty;
                    nome.Enabled = false;
                    cracha.Enabled = false;
                    setor.Enabled = false;
                    cargo.Enabled = false;
                }
            }
        }
    }
}