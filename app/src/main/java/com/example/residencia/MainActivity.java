package com.example.residencia;

import android.content.Context;
import android.content.DialogInterface;
import android.support.annotation.NonNull;
import android.support.constraint.ConstraintLayout;
import android.support.design.widget.TextInputLayout;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

import com.google.firebase.FirebaseApp;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import org.w3c.dom.Text;

import java.sql.Struct;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    ConstraintLayout back;
    FirebaseDatabase _FirebaseDatabase;
    DatabaseReference _DatabaseReference,CounterReferences,_CtlRefence,InfoReference;
     RadioGroup carrreas;
     RadioButton selCarrera;
 //   String c;
    String valor;
    TextInputLayout tel,nombre,empresa,control,asesor,correo,proyecto;
    EditText carrera;

    TextView txt;
    Button ingresar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        setTheme(R.style.AppTheme);
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        back = findViewById(R.id.idact);
   //     back.setBackgroundResource(R.drawable.logo);
        nombre = findViewById(R.id.txtnombre);
        empresa = findViewById(R.id.txtempresa);
        control = findViewById(R.id.txtcontrol);
        proyecto = findViewById(R.id.txtproyecto);
        asesor = findViewById(R.id.txtasesor);
        carrreas = findViewById(R.id.carrera);
        correo = findViewById(R.id.txtcorreo);
        tel = findViewById(R.id.txttelefono);
        ingresar = findViewById(R.id.btnenviar);
        initializeFirebase();
txt = findViewById(R.id.txt);


         InfoReference = FirebaseDatabase.getInstance().getReference("estudiante");
         CounterReferences = FirebaseDatabase.getInstance().getReference("Counter");
         _CtlRefence = FirebaseDatabase.getInstance().getReference("Control");

         CounterReferences.child("/Node").addValueEventListener(new ValueEventListener() {
             @Override
             public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                 valor = String.valueOf( dataSnapshot.getValue());
             }
             @Override
             public void onCancelled(@NonNull DatabaseError databaseError) {

             }
         });


    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.main_menu,menu);
        return super.onCreateOptionsMenu(menu);
    }

    public void add(View view){
        _CtlRefence.addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                    if(dataSnapshot.child(control.getEditText().getText().toString()).exists()){
                        Toast t = Toast.makeText(MainActivity.this, "No. Control ya existe", Toast.LENGTH_SHORT);
                   t.show();
                    }
                    else {
                        Alertdialog();
                    }

            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });

    }
    public  void insert(){

            try {
                int selecion = carrreas.getCheckedRadioButtonId();
                selCarrera = findViewById(selecion);
                //
                String _nombre = nombre.getEditText().getText().toString();
                String _Empresa = empresa.getEditText().getText().toString();
                String _proyecto = proyecto.getEditText().getText().toString();
                String _asesor = asesor.getEditText().getText().toString();
                String _carrera = selCarrera.getText().toString();
                String _correo = correo.getEditText().getText().toString();
                int _numero = 1;
                int _Noctl = Integer.parseInt(control.getEditText().getText().toString());
                String _tel = tel.getEditText().getText().toString();
                String c = String.valueOf(Integer.parseInt(valor) + 1);
                Info i = new Info(c, _proyecto, _asesor, _nombre, _carrera, _correo, _Empresa, _numero, _Noctl, _tel);
                if (_nombre.isEmpty() || _carrera.isEmpty() || _Empresa.isEmpty()||_proyecto.isEmpty()||_asesor.isEmpty()||_correo.isEmpty()||control.equals("")||_tel.isEmpty() ) {
                    Toast t = Toast.makeText(MainActivity.this, "Llenar todo los Campos", Toast.LENGTH_SHORT);
                    t.show();
                } else {
                    _CtlRefence.child(String.valueOf(_Noctl)).setValue(_Noctl);
                    CounterReferences.child("/Node").setValue(c);
                    InfoReference.child(String.valueOf(c)).setValue(i);
                    selCarrera.setChecked(false);
                    clean();
                }
            }
            catch(Exception ex) {
                Toast t = Toast.makeText(MainActivity.this, "Intenta mas tarde", Toast.LENGTH_SHORT);
                t.show();
            }
    }

    private void initializeFirebase() {
        FirebaseApp.initializeApp(this);
        _FirebaseDatabase=FirebaseDatabase.getInstance();
        _DatabaseReference=_FirebaseDatabase.getReference();
    }
    public  void clean(){

        nombre.getEditText().setText("");
        empresa .getEditText().setText("");
        control .getEditText().setText("");
        proyecto .getEditText().setText("");
        asesor .getEditText().setText("");
    //    carrreas = findViewById(R.id.carrera);
        correo .getEditText().setText("");
        tel .getEditText().setText("");

    }

    public void Alertdialog(){

        AlertDialog.Builder alert = new AlertDialog.Builder(this);
        alert.setTitle("Confirmar la solicitud");
        alert.setMessage("¿Seguro que quiere mandar la solicitud?\n ya no lo podra mandar de nuevo");
        alert.setPositiveButton("Enviar", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

              insert();

            }
        });
        alert.setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

            }
        });
        alert.show();


    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item){
        switch (item.getItemId()){
            case R.id.info:
                new AlertDialog.Builder(MainActivity.this)
                        .setTitle("Acerca de")
                        .setMessage("Esta aplicacion fue desarrollada solamente para el departamento de \n Metal Mecanica")
                        .setPositiveButton("Cerrar", new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {

                            }
                        }).show();

                break;
        }
        return  true;
    }


}
