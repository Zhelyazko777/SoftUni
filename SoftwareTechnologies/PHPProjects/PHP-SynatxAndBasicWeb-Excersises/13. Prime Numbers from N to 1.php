<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if (isset($_GET['num'])) {
        $primeNums = [];
        for ($i = 2;$i <= $_GET['num'];$i++) {
            $isPrime = true;
            for ($j = 2;$j < $i; $j++) {
                if ($i % $j == 0) {
                    $isPrime = false;
                    break;
                }
            }
            if ($isPrime) {
                $primeNums[] = $i;
            }
        }
        echo implode(" ", array_reverse($primeNums));
    }
    ?>
</body>
</html>