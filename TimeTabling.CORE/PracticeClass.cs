namespace TimeTabling.CORE
{
    /// <summary>
    /// Tipo de clases practicas 
    /// </summary>
    public enum PracticeClass : int
    {
        /// <summary>
        /// Clase de laboratorio sin instalaciones informaticas
        /// </summary>
        Laboratorio = 0,

        /// <summary>
        /// Clase de informatica con instalaciones informaticas para instalar software necesario
        /// </summary>
        ClaseInformatica = 1,

        /// <summary>
        /// La clase no ha sido elegida para esta asignatura
        /// </summary>
        Close = 2
    }
}