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
        $arr = [1, 1];
        for ($i = 0;$i < $_GET['num'] - 2;$i++) {
            $arr[$i + 2] = $arr[$i + 1] + $arr[$i];
        }
        echo implode(", ", $arr);
    }
    ?>
</body>
</html>