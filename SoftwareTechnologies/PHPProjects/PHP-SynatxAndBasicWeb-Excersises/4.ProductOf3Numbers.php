<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num1" />
    N2: <input type="text" name="num2" />
    N3: <input type="text" name="num3" />
    <input type="submit" >
</form>
<?php
if(isset($_GET["num1"]) && isset($_GET["num2"]) && isset($_GET["num3"])) {
    if(intval($_GET["num1"])  * intval($_GET["num2"]) * intval($_GET["num3"]) >= 0) {
        echo "Positive";
    }
    else {
        echo "Negative";
    }
}
?>
</body>
</html>
