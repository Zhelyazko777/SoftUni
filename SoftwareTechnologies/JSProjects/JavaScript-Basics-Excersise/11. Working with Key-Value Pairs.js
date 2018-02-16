function f(arr) {
    let obj = {};
    for(let i = 0; i < arr.length - 1; i++) {
        let pair = arr[i].split(" ");
        let key = pair[0];
        let value = pair[1];
        obj[key] = value;
    }
    let command = arr[arr.length - 1];
    if(obj[command] == undefined) {
        console.log("None");
    }
    else {
        console.log(obj[command]);
    }
}