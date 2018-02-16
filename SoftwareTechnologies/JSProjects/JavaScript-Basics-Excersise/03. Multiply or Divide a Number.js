function f([num1, num2]) {
    num1 = Number(num1);
    num2 = Number(num2);
    let sum = 0;
    if(num1 > num2) {
        sum = num1 / num2;
    }
    else {
        sum = num1 * num2;
    }
    console.log(sum);
}