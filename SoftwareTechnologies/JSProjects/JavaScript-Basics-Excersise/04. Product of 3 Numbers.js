function f([num1, num2, num3]) {
    num1 = Number(num1);
    num2 = Number(num2);
    num3 = Number(num3);
    let result = num2 * num1 * num3;
    if(result < 0) {
        console.log("Negative");
    }
    else {
        console.log("Positive");
    }
}