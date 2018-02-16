function f(arr) {
    let obj = {};
    for(let i = 0; i < arr.length - 1; i++) {
        let pair = arr[i].split(" ");
        let key = pair[0];
        let value = pair[1];
        if(!obj.hasOwnProperty(key)) {
            obj[key] = [];
        }
        obj[key].push(value);
    }
    if(!obj.hasOwnProperty(arr[arr.length - 1])) {
        console.log("None");
        return;
    }
    console.log(obj[arr[arr.length - 1]].join("\r\n"));
}