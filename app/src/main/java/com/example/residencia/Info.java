package com.example.residencia;

public class Info {
    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    private   String id,proyecto, asesor,nombre,carrera,correo,empresa,tel,apellido;
   private int numero;
    private int control;




    public String getTel() {
        return tel;
    }

    public void setTel(String tel) {
        this.tel = tel;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public String getProyecto() {
        return proyecto;
    }

    public void setProyecto(String proyecto) {
        this.proyecto = proyecto;
    }

    public String getAsesor() {
        return asesor;
    }

    public void setAsesor(String asesor) {
        this.asesor = asesor;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getCarrera() {
        return carrera;
    }

    public void setCarrera(String carrera) {
        this.carrera = carrera;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getEmpresa() {
        return empresa;
    }

    public void setEmpresa(String empresa) {
        this.empresa = empresa;
    }



    public int getControl() {
        return control;
    }

    public void setControl(int control) {
        this.control = control;
    }


    public Info(String id,String proyecto, String asesor, String nombre, String carrera, String correo, String empresa, int numero, int control, String tel) {
        this.id = id;
        this.proyecto = proyecto;
        this.asesor = asesor;
        this.nombre = nombre;
        this.carrera = carrera;
        this.correo = correo;
        this.empresa = empresa;
        this.numero = numero;
        this.control = control;
        this.tel = tel;

    }

    public int getNumero() {
        return numero;
    }
}
