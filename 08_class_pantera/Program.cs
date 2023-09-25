using Animal.Model;

class Program{
    public static void Main(){
        var Pantera1 = new Pantera();
        Pantera1.corre = "correndo";
        Pantera1.alimentacao = "lebres, insetos e peixes";
        Pantera1.reproducao = "tres";
        Pantera1.Cor ="preto";
        Pantera1.Alimentar = "carnes";
        Pantera1.Reproduzir();
    }
}