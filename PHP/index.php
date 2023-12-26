<!DOCTYPE html>
<html>

<head>

    <link rel="stylesheet" href="/public_html/php/VSC PHP/style.css">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Descripción de tu página">
    <meta name="keywords" content="palabra clave 1, palabra clave 2, palabra clave 3">
    <meta name="author" content="Nombre del autor">
    <meta http-equiv="Content-Security-Policy" content="default-src 'self'">
    
    <title>Indice de masa corporal</title>

</head>

<body>




    <header>
        <div class="barra-superior">

        </div>
        <h1 class="titulo">Indice de masa corporal</h1>

    </header>


    <main>

        <div class="Parrafo">

            <br>

            <p>Bienvenido a nuestra herramienta de cálculo del Índice de Masa Corporal (IMC). El IMC es una medida que
                evalúa la relación entre tu peso y altura, proporcionando una indicación general de la cantidad de grasa
                corporal. Este índice es útil para evaluar la salud y el riesgo de enfermedades asociadas al peso.
                Nuestra calculadora te permite ingresar fácilmente tu peso y altura, y luego obtendrás tu IMC
                instantáneamente. Recuerda que el IMC es una herramienta de referencia y no debe considerarse como un
                diagnóstico médico definitivo. Consulta a un profesional de la salud para obtener una evaluación
                completa. ¡Descubre hoy mismo cómo tu IMC puede ser un paso hacia un estilo de vida más saludable 
                ingresando tus datos para calcular tu indice de masa corporal a continuación !</p>
        </div>

         <br>
         <br>

        <div class="cuerpo_m">

            <form action="calcular.php" method="post">
                <label for="peso" >Peso(kg):</label>
                <input type="peso" name="peso" required placeholder="Ej: 86"><br>
                <br>
                <label for="altura">Altura(Metros):</label>
                <input type="altura" name="altura" required placeholder="Ej: 1.70"><br>
                <br>
                <br>
                <input type="submit" value="Calcular IMC">
                
            </form>

        </div>


    </main>


    <footer>

    <div class="barra-inferior"></div>

    </footer>
</body>

</html>