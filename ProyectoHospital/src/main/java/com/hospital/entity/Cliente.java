package com.hospital.entity;

public class Cliente {

    private int id_Cliente;
    private String nombre;
    private String apellido;
    private String genero;
    private String correo;
    private String direccion;
    private int telefono;

    public Cliente() {
    }

    public Cliente(int id_Cliente, String nombre, String apellido, String genero, String correo, String direccion, int telefono)
    {
        this.id_Cliente = id_Cliente;
        this.nombre = nombre;
        this.apellido = apellido;
        this.genero = genero;
        this.correo = correo;
        this.direccion = direccion;
        this.telefono = telefono;
    }

    public int getId_Cliente() {
        return id_Cliente;
    }

    public void setId_Cliente(int id_Cliente) {
        this.id_Cliente = id_Cliente;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccionn;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    @Override
    public String toString() {
        return "Cliente{" + "id_Cliente=" + id_Cliente + ", nombre=" + nombre + ", apellido=" + apellido + ", género=" + genero + ", correo=" + correo + ", dirección=" + direccion + ", teléfono=" + telefono + '}';
    }



}
