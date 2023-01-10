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
    public class TelaDeletar : AppCompatActivity
    {
        EditText nome;
        EditText cracha;
        EditText setor;
        EditText cargo;
        Button buscar;
        Button remover;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.TelaDeletar);

            nome = FindViewById<EditText>(Resource.Id.textNome);
            cracha = FindViewById<EditText>(Resource.Id.textCracha);
            setor = FindViewById<EditText>(Resource.Id.textSetor);
            cargo = FindViewById<EditText>(Resource.Id.textCargo);
            buscar = FindViewById<Button>(Resource.Id.btnBuscar);
            remover = FindViewById<Button>(Resource.Id.btnRemover);

            // Create your application here

            buscar.Click += delegate
            {
                search();
            };

            remover.Click += delegate
            {
                delete();
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
        private void delete()
        {
            if (cracha.Text == "" && nome.Text == "" && setor.Text == "" && cargo.Text == "")
            {
                Toast.MakeText(this, "Sem dados para remover", ToastLength.Short).Show();
            }
            else
            {
                bool retorno = controlador.delete(nome.Text);
                if (retorno == true)
                {
                    Toast.MakeText(this, "Registro removido", ToastLength.Short).Show();
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