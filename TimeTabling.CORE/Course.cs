namespace TimeTabling.CORE
{
        /// <summary>
        /// Tipo de cursos por asignatura
        /// </summary>
        public enum Course : int
        {
            /// <summary>
            /// Curso simple de teoria para esta asignatura
            /// </summary>
            CursoTeorico = 0,

            /// <summary>
            /// Curso simple de grado medio para esta asignatura
            /// </summary>
            CursoMedio = 1,

            /// <summary>
            /// Curso simple de grado superior para etsa asignatura
            /// </summary>
            CursoSuperior = 2,

            /// <summary>
            /// Curso de postgrado para esta asignatura
            /// </summary>
            Postgrado = 3
        }
}