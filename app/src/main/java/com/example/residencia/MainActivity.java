package com.example.residencia;

import android.content.Context;
import android.content.DialogInterface;
import android.support.annotation.NonNull;
import android.support.constraint.ConstraintLayout;
import android.support.design.widget.TextInputLayout;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
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
    TextInputLayout tel,nombre,empresa,apellido,control,asesor,correo,proyecto;
    EditText carrera;

    TextView txt;
    Button ingresar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        back = findViewById(R.id.idact);
   //     back.setBackgroundResource(R.drawable.logo);
        nombre = findViewById(R.id.txtnombre);
        apellido = findViewById(R.id.txtapelldio);
        empresa = findViewById(R.id.txtempresa);
        control = findViewById(R.id.txtcontrol);
        proyecto = findViewById(R.id.txtproyecto);
        asesor = findViewById(R.id.txtasesor);
       ;
      //  carrera = findViewById(R.id.txtcarrera);
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

    public void add(View view){
        Alertdialog();
    }
    public  void insert(){

            //
        int selecion = carrreas.getCheckedRadioButtonId();
        selCarrera = findViewById(selecion);
        //
            String _nombre = nombre.getEditText().getText().toString();
            String _Apelldio = apellido.getEditText().getText().toString();
            String _Empresa = empresa.getEditText().getText().toString();
            String _proyecto = proyecto.getEditText().getText().toString();
            String _asesor = asesor.getEditText().getText().toString();
            String _carrera = selCarrera.getText().toString();
            String _correo = correo.getEditText().getText().toString();
            int _numero = 1;
            int _Noctl = Integer.parseInt(control.getEditText().getText().toString());
            String _tel = tel.getEditText().getText().toString();
            String c = String.valueOf(Integer.parseInt(valor) + 1);
            Info i = new Info(c,_proyecto, _asesor, _nombre, _Apelldio, _carrera, _correo, _Empresa, _numero, _Noctl, _tel);
//        if(nombre.equals("") || apellido.equals("") || empresa.equals("")||proyecto.equals("")||asesor.equals("")||carrera.equals("")||correo.equals("") ||control.equals("")||tel.equals("")) {
//            nombre.setError("Campo no puede estar vacio");
//
//        }
//   else {
            _CtlRefence.child(String.valueOf(_Noctl)).setValue(c);
            CounterReferences.child("/Node").setValue(c);
            InfoReference.child(String.valueOf(c)).setValue(i);

        //}
    }

    private void initializeFirebase() {
        FirebaseApp.initializeApp(this);
        _FirebaseDatabase=FirebaseDatabase.getInstance();
        _DatabaseReference=_FirebaseDatabase.getReference();
    }

    public void Alertdialog(){
        AlertDialog.Builder alert = new AlertDialog.Builder(this);
        alert.setTitle("Confirmar la solicitud");
        alert.setMessage("¿Seguro que quiere mandar la solicitud?\n ya lo no podra a mandar de nuevo");
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


}
