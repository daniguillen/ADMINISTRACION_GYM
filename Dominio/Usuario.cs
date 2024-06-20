namespace Dominio
{
    public class Usuario : Persona
    {

        public Usuario()
        {
            Persona Persona = new Persona();
            nivel = new Nivel();
        }
        public string Mail { get; set; }

        public string Password { get; set; }

        public Nivel nivel { get; set; }

    }


}