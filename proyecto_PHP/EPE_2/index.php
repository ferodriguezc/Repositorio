<!-- Definición del tipo de documento y etiquetas principales -->
<!DOCTYPE html>
<html>

<head>
    <!-- Enlaces y Metadatos -->
    <link rel="stylesheet" href="style.css">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="pagina para calcular IMC">
    <meta name="keywords" content="ICM, Salud, Peso">
    <meta name="author" content="felipe RC">
    <meta http-equiv="Content-Security-Policy" content="default-src 'self'">

    <!-- Título de la Página -->
    <title>Indice de masa corporal</title>
</head>
    
    <!-- Cuerpo de la Página -->
<body class="cuerpo_Pag">
    

    <!-- Encabezado -->
    <header class="header">
        <div class="barra-superior">
            <h1 class="titulo">Indice de masa corporal</h1>
        </div>
    </header>

    <!-- Contenido Principal -->
    <main class="Principal">
        <!-- Descripción de la calculadora IMC -->
        <div class="Parrafo">
            <p>Bienvenido a nuestra herramienta de cálculo del Índice de Masa Corporal (IMC). El IMC es una medida que
                evalúa la relación entre tu peso y altura, proporcionando una indicación general de la cantidad de grasa
                corporal. ¡Descubre hoy mismo cómo tu IMC puede ser un paso hacia un estilo de vida más saludable
                ingresando tus datos para calcular tu índice de masa corporal a continuación!</p>
        </div>

        <!-- Formulario de Cálculo de IMC -->
        <div class="marco">
            <div class="cuerpo_m">
                <form action="calcular.php" method="post">
                    <label>Peso(kg):</label>
                    <input class="calculadora" type="peso" name="peso" required placeholder="Ej: 86"><br>
                    <br>
                    <label>Altura(Metros):</label>
                    <input  class="calculadora" type="altura" name="altura" required placeholder="Ej: 1.70"><br>
                    <br>
                    <br>
                    <input class="calculadora" type="submit" value="Calcular IMC">
                </form>
            </div>
        </div>
    </main>

    <!-- Pie de Página -->
    <footer>
        <div><p>Derechos reservados</p></div>
    </footer>

</body>
</html>
