<!DOCTYPE html>
<html>
<head>
    <title>Resultado de la Suma</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <h1 >Resultado de la Suma</h1>


    <div class="fondo">
    <?php  ;
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $peso = $_POST["peso"];
        $altura = $_POST["altura"];
      

        $resultado = $peso / (($altura * $altura) / 10000);

        echo "Su indice de masa corporal es: $resultado";
       
        if ($resultado < 18.5) {

            echo"BAJO PESO  ","\n";
           
            echo  '<img src="peso_1.png" alt="bajo_peso">';
        }    
    }
    ?>
    </div>

    <br>

     <button><a href="javascript:history.go(-1)">Volver a la página anterior</a></button>
     
</body>
</html>
