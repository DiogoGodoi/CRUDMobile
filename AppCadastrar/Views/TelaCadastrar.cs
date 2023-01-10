using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndroidX.AppCompat.App;
using Controlador;
using Funcionario;

namespace AppCadastrar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class TelaCadastrar : AppCompatActivity
    {
        EditText txtCracha;
        EditText txtNome;
        EditText txtSetor;
        EditText txtCargo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.TelaCadastrar);

            txtCracha = FindViewById<EditText>(Resource.Id.editCracha);
            txtNome = FindViewById<EditText>(Resource.Id.editNome);
            txtSetor = FindViewById<EditText>(Resource.Id.editSetor);
            txtCargo = FindViewById<EditText>(Resource.Id.editCargo);

            Button btnCadastrar = FindViewById<Button>(Resource.Id.btnCadastrar);

            btnCadastrar.Click += delegate
            {
                var cracha = txtCracha.Text;
                var nome = txtNome.Text;
                var setor = txtSetor.Text;
                var cargo = txtCargo.Text;

                if (cracha == String.Empty)
                {
                    Toast.MakeText(this, "Por favor insira o crachá do funcionario", ToastLength.Short).Show();
                }else if (nome == String.Empty)
                {
                    Toast.MakeText(this, "Por favor insira o nome do funcionário", ToastLength.Short).Show();
                }else if (setor == String.Empty)
                {
                    Toast.MakeText(this, "Por favor insira o setor do funcionario", ToastLength.Short).Show();
                }else if (cargo == String.Empty)
                {
                    Toast.MakeText(this, "Por favor insira o cargo do funcionario", ToastLength.Short).Show();
                }
                else {

                   mdlFuncionario mdlFuncionario = new mdlFuncionario(cracha, nome.ToUpper(), setor.ToUpper(), cargo.ToUpper());
                   bool retorno =  insert(mdlFuncionario);

                if (retorno == true)
                {
                    Toast.MakeText(this, "Cadastrado com sucesso", ToastLength.Short).Show();
                    txtCracha.Text = String.Empty;
                    txtNome.Text = String.Empty;
                    txtSetor.Text = String.Empty;
                    txtCargo.Text = String.Empty;
                    }
                else
                {
                    Toast.MakeText(this, "Erro", ToastLength.Short).Show();
                }
                }
            };
        }

        private bool insert(mdlFuncionario mdlFuncionario)
            {
            bool retorno = controlador.insert(mdlFuncionario);
                if(retorno == true)
            {
                return true;
            }
            else
            {
                return false;
            }

            }
        }
    }
