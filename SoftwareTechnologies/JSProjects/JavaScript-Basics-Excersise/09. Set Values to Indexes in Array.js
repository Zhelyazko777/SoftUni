function f(arr) {
    let arrLength = Number(arr[0]);
    let myArr = [];
    for(let i = 0; i < arrLength; i++) {
        myArr[i] = 0;
    }
    for(let i = 1; i < arr.length; i++) {
        let commands = arr[i].split(" ");
        let index = commands[0];
        let num = commands[2];
        myArr.splice(index, 1);
        myArr.splice(index, 0, num)
    }
    console.log(myArr.join("\r\n"));
}