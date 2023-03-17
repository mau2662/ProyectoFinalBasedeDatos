package com.hospital.entity;

public class Empleado {

    private int id_Empleado;
    private String nombre;
    private String apellido;
    private String correo;
    private String telefono;
    private String fecha_Contratacion;
    private int salario;

    public Empleado() {
    }

    public Empleado(int id_Empleado, String nombre,String apellido, String correo, String telefono, String fecha_Contratacion, int salario) {
        this.id_Empleado = id_Empleado;
        this.nombre = nombre;
        this.apellido = apellido;
        this.correo = correo;
        this.telefono = telefono;
        this.fecha_Contratacion = fecha_Contratacion;
        this.salario = salario;
    }

    public int getId_Empleado() {
        return id_Empleado;
    }

    public void setId_Empleado(int id_Empleado) {
        this.id_Empleado = id_Empleado;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getFecha_Contratacion() {
        return fecha_Contratacion;
    }

    public void setFecha_Contratacion(String fecha_Contratacion) {
        this.fecha_Contratacion = fecha_Contratacion;
    }

    public int getSalario() {
        return salario;
    }

    public void setSalario(int salario) {
        this.salario = salario;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    @Override
    public String toString() {
        return "Empleado{" + "id_Empleado=" + id_Empleado + ", nombre=" + nombre + ", apellido=" + apellido + ", correo=" + correo + ", telefono=" + telefono + ", fecha_Contratacion=" + fecha_Contratacion + ", salario=" + salario + '}';
    }

 
}
