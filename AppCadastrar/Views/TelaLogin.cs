using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using controladorLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Usuario;
using UsuarioDAO;

namespace AppCadastrar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class TelaLogin : AppCompatActivity
    {
        EditText usuario;
        EditText senha;
        EditText ip;
        EditText port;
        Button entrar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.Login);

            usuario = FindViewById<EditText>(Resource.Id.textUsuario);
            senha = FindViewById<EditText>(Resource.Id.textSenha);
            ip = FindViewById<EditText>(Resource.Id.textHostIP);
            port = FindViewById<EditText>(Resource.Id.txtPort);
            entrar = FindViewById<Button>(Resource.Id.btnEntrar);
            
            entrar.Click += delegate
            {
                string usuarioText = usuario.Text;
                string senhaText = senha.Text;
                string ipText = ip.Text;    
                string portText = port.Text;
                mdlUsuario mdlUsuario = new mdlUsuario(usuarioText.ToUpper(), senhaText.ToUpper());
                new daoUsuario(usuarioText.ToUpper(), senhaText.ToUpper(), ipText, portText);
                bool retorno = ctrlLogin.autenticar(mdlUsuario);
                if (retorno == true)
                {
                    StartActivity(typeof(TelaPrincipal));
                }
                else
                {
                    Toast.MakeText(this, "Erro, usuário ou senha inválidos", ToastLength.Short).Show();
                }
            };
        }
        private bool logar(mdlUsuario mdlUsuario)
        {
           bool retorno =  ctrlLogin.autenticar(mdlUsuario);
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