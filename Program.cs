using EjemploObjetos;

string cadena = "gika";

//declarar un objeto
BanquitoComputacion banquito;

//instanciar un objeto
banquito = new BanquitoComputacion("madera", 4, "verde");

BanquitoComputacion banquito2 = new BanquitoComputacion("metal", -1, "rojo");

var banquito3 = new BanquitoComputacion("plastico", 10, "negro");

//llamar al método Informar
banquito.Informar();
banquito.Pintar("purpura");
banquito.Informar();
banquito2.Informar();
banquito3.Informar();