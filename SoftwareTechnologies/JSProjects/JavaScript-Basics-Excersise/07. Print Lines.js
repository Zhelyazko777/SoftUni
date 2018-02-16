function f(arr) {
    let objArr = arr;
    let newArr = [];
    for(let i = 0; i < objArr.length; i++) {
        if(objArr[i] == "Stop") {
            break;
        }
        newArr[i] = objArr[i];
    }
    console.log(newArr.join("\r\n"));
}