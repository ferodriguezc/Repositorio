<!DOCTYPE html>
<html>

<head>
    <!-- Definición del título de la página, Metadatos, enlace al archivo de estilos externo -->
    <title>RESULTADO DE INDICE DE MASA CORPORAL</title>
    <link rel="stylesheet" type="text/css" href="style.css">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="pagina para calcular IMC">
    <meta name="keywords" content="ICM, Salud, Peso">
    <meta name="author" content="felipe RC">
    <meta http-equiv="Content-Security-Policy" content="default-src 'self'">
</head>

<body>

    <header>
        <!-- Encabezado de la página -->
        <div class="barra-superior"><h1 class="titulo">INDICE DE MASA CORPORAL</h1></div>
    </header>

    <main>

        <div class="fondo">
            
            <div class="resultado">
                <?php
                // Verificar si se ha enviado el formulario
                if ($_SERVER["REQUEST_METHOD"] == "POST") {
                    // Obtener el peso y la altura del formulario
                    $peso = $_POST["peso"];
                    $altura = $_POST["altura"];
                    // Calcular el IMC
                    $resultado = $peso / ($altura * $altura);
                }
                ?>

                <h2></h2>

                <div>
                    <?php
                    // Mostrar el resultado del IMC y proporcionar información según el rango
                    if ($resultado < 18.5) {
                        // Bajo peso
                        echo '<br>';
                        echo '<img src="fotos\peso_1.png" alt="bajo_peso">';
                        echo '<img src="fotos\peso_m1.png" alt="bajo_peso">';
                        echo "<h2>Su indice de masa corporal es: $resultado</h2>  ";
                        echo '<p class="subtitulo"><h2>BAJO PESO</h2></p>';
                        echo '<p class= "subpeso"> El bajo peso también presenta riesgos para la salud.
                             Puede debilitar el sistema inmunológico, aumentar la vulnerabilidad
                             a enfermedades y afectar el desarrollo físico y mental.
                             Problemas como la falta de energía, fatiga y deficiencias
                             nutricionales son comunes. Para abordar el bajo peso, es
                             esencial seguir una dieta equilibrada y nutritiva, rica
                             en proteínas, grasas saludables y carbohidratos.
                             Consultar a un profesional de la salud para un plan personalizado
                             y supervisión es crucial. Incrementar la actividad física de
                             manera gradual también puede ser beneficioso. Es fundamental buscar
                             ayuda y apoyo para lograr un peso saludable y mejorar el bienestar.</p>';

                    } else if ($resultado > 18.5 && $resultado < 24.9) {
                        // Peso saludable
                        echo '<img src="fotos\peso_2.png" alt="saludable">';
                        echo '<img src="fotos\peso_m2.png" alt="saludable">';
                        echo "<h2>Su indice de masa corporal es: $resultado</h2> ";
                        echo '<p class="subtitulo"><h2>SALUDABLE</h2></p>';
                        echo '<p class= "subpeso"> La salud se logra manteniendo
                              un equilibrio en tu estilo de vida. Comer alimentos variados
                              y nutritivos, como frutas, verduras, granos enteros y proteínas
                              magras, es esencial. Beber suficiente agua y limitar el consumo
                              de alimentos procesados ayuda a mantener el cuerpo en buen estado.
                              La actividad física regular, como caminar o hacer ejercicio
                              moderado, contribuye a la salud cardiovascular y mental.
                              Asegurarse de dormir lo suficiente también es clave.
                              Mantener relaciones sociales positivas y manejar el estrés de
                              manera efectiva complementa una vida saludable. ¡Recuerda,
                              pequeños cambios diarios suman grandes beneficios para
                              tu bienestar!.</p>';

                    } else if ($resultado > 25 && $resultado < 29.9) {
                        // Sobrepeso
                        echo '<img src="fotos\peso_3.png" alt="bajo_peso">';
                        echo '<img src="fotos\peso_m3.png" alt="bajo_peso">';
                        echo "<h2>Su indice de masa corporal es: $resultado</h2>  ";
                        echo '<p class="subtitulo"><h2>SOBREPESO </h2></p>';
                        echo ' <p class= "subpeso"> El sobrepeso puede traer
                               riesgos para la salud. Aumenta la probabilidad de enfermedades
                               cardíacas, diabetes y problemas articulares. Además, puede afectar
                               la autoestima y la salud mental. Para abordar el sobrepeso, es
                               vital adoptar hábitos saludables. Comer porciones adecuadas, elegir
                               alimentos nutritivos y mantenerse activo son pasos importantes.
                               Incorporar ejercicio regular, como caminar o nadar, puede ser beneficioso.
                               Consultar con un profesional de la salud para un plan de pérdida de peso
                               seguro y sostenible es recomendable. Establecer metas realistas y buscar
                               apoyo social puede hacer que el proceso sea más exitoso. Recordar que
                               pequeños cambios suman a una mejor salud..</p>';

                    } else if ($resultado > 30 && $resultado < 39.99) {
                        // Obesidad
                        echo '<img src="fotos\peso_4.png" alt="bajo_peso">';
                        echo '<img src="fotos\peso_m4.png" alt="bajo_peso">';
                        echo "<h2>Su indice de masa corporal es: $resultado</h2> ";
                        echo '<p class="subtitulo"><h2>OBESIDAD</h2> </p>';
                        echo ' La obesidad es un problema de salud
                               grave que ocurre cuando hay un exceso de acumulación
                               de grasa en el cuerpo. Esto puede aumentar el riesgo
                               de diversas enfermedades, como diabetes tipo 2, enfermedades
                               cardíacas y problemas articulares. Además de los riesgos físicos,
                               la obesidad también puede afectar la salud mental y la calidad
                               de vida. Para abordar la obesidad, es fundamental adoptar un enfoque
                               equilibrado. Cambios en la dieta, como elegir alimentos más saludables
                               y controlar las porciones, junto con la incorporación de actividad
                               física regular, son clave. Buscar apoyo profesional y establecer
                               metas realistas pueden hacer que la pérdida de peso sea más
                               efectiva y sostenible.';

                    } else if ($resultado > 40) {
                        // Obesidad severa
                        echo '<img src="fotos\peso_5.png" alt="bajo_peso">';
                        echo '<img src="fotos\peso_m5.png" alt="bajo_peso">';
                        echo "<h2>Su indice de masa corporal es: $resultado</h2> ";
                        echo '<p class= "subtitulo"> <h2> OBESIDAD SEVERA </h2></p> ';
                        echo 'La obesidad severa conlleva riesgos graves
                              para la salud. Aumenta la probabilidad de
                              enfermedades cardíacas, diabetes tipo 2 y problemas
                              respiratorios. Además, puede afectar las articulaciones
                              y causar trastornos emocionales. Para combatir
                              estos peligros, es crucial adoptar un enfoque equilibrado.
                              Incorporar una dieta saludable y ejercicio regular es
                              fundamental. Consultar a un médico para un plan de pérdida de peso
                              seguro y sostenible también es importante. Establecer metas
                              realistas y buscar apoyo social puede hacer que el proceso
                              sea más efectivo. La obesidad severa no solo afecta el
                              cuerpo, sino también la calidad de vida, por lo que abordarla
                              es esencial.';
                    }
                    ?>
                </div>

            </div>
        </div>
        <br>

        <div class="posicion_boton">
            <!-- Botón para volver a la página principal -->
            <button><a class="ref" href="index.php">Volver a la página anterior</a></button>
        </div>

    </main>

    <footer>
        <!-- Pie de página -->

        <div><p>Derechos reservados</p></div>

    </footer>

</body>
</html>