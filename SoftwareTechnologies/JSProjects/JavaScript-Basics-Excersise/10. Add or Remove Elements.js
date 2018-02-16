function f(arr) {
    let myArr = [];
    for(let i = 0; i < arr.length; i++) {
        let commandInf = arr[i].split(" ");
        let command = commandInf[0];
        let num = commandInf[1];
        if(command == "add") {
            myArr.push(num);
        }
        else if(command == "remove") {
            myArr.splice(num, 1);
        }
    }
    console.log(myArr.join("\r\n"));
}