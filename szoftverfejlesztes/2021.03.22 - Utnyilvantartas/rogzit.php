<?php
$datumErr=$honnanErr=$hovaErr=$kmErr="";


if($_SERVER['REQUEST_METHOD']=="POST"){
    if(isset($_POST['datum'])){
        $datum=$_POST['datum'];
    }else{
        $datumErr="Hibás dátum formátum";
    }

    if(isset($_POST['honnan']) && strlen(trim($_POST['honnan']))>=3){
        $honnan=$_POST['honnan'];
    }else{
        $honnanErr="Hibás beviteli mező";
    }

    if(isset($_POST['hova']) && strlen(trim($_POST['hova']))>=3){
        $hova=$_POST['hova'];
    }else{
        $hovaErr="Hibás beviteli mező";
    }

    if(isset($_POST['km']) && $_POST['km']>0.00){
        $km=$_POST['km'];
    }else{
        $kmErr="Hibás érték";
    }
}

?>


<!doctype html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <title>Útnyilvántartás</title>
</head>
<body>
    <?php
    require "menu/header.php";
    ?>

    <form action="<?php echo $_SERVER['PHP_SELF'];?>" method="post">
        <table>
            <tr>
                <td><h1>Rögzítés</h1></td>
            </tr>
            <tr>
                <td> Dátum:  </td>
                <td><input name="datum" type="date" value="<?php echo date("Y-m-d");?>" required></td>
                <td>* <?php echo $datumErr;?></td>
            </tr>

            <tr>
                <td> Honnan: </td>
                <td><input name="honnan" type="text" required></td>
                <td>* <?php echo $honnanErr;?></td>
            </tr>
            <tr>
                <td> Hová: </td>
                <td><input name="hova" type="text" required></td>
                <td>* <?php echo $hovaErr;?></td>
            </tr>
            <tr>
                <td> Km:</td>
                <td><input name="km" type="number" step='0.01' value='0.00' required></td>
                <td>* <?php echo $kmErr;?></td>
            </tr>
            <tr>
                <td colspan="3" align="right"><input type="submit" value="Rögzít"></td>
            </tr>
        </table>
    </form>
</body>
</html>

<?php

if(isset($datum) && isset($honnan) && isset($hova) && isset($km)){
    require "db/connection.php";

    $sql = "INSERT INTO utak (ID_user, Datum, Honnan, Hova, km)
            VALUES ('1', $datum, $honnan, '$hova', '$km')";

    if ($conn->query($sql) === TRUE) {
        echo "Beirva az adatbázisba";
    } else {
        echo "HIba: " . $sql . "<br>" . $conn->error;
    }

    $conn->close();
}
