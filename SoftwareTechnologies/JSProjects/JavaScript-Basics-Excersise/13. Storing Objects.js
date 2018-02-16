function f(arr) {
    for(let i = 0; i < arr.length; i++) {
        let obj = {};
        let splitedArr = arr[i].split("->");
        let name = splitedArr[0].trim();
        let age = splitedArr[1].trim();
        let grade = splitedArr[2].trim();
        obj = {"Name": name, "Age": age, "Grade": grade};
        console.log("Name: " + obj.Name);
        console.log("Age: " + obj.Age);
        console.log("Grade: " + obj.Grade);
    }
}