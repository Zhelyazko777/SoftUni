function f(arr) {
    let obj = {};
    let values = arr.forEach(p => {
        let [key, value] = p.split("->");
        if (Number.isInteger(Number(value))) {
            value = Number(value);
        }
        obj[key] = value;
    });
    return JSON.stringify(obj);
}