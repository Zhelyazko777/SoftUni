function Calculator(leftOperand, operator, rightOperand) {
    this.leftOperand = leftOperand;
    this.operator = operator;
    this.rightOperand = rightOperand;


    this.calculateResult = function () {
        let result = 0;

        if(this.operator === "+") {
            result = Number(this.leftOperand) + Number(this.rightOperand);
        }
        else if(this.operator === "-") {
            result = Number(this.leftOperand) - Number(this.rightOperand);
        }
        else if(this.operator === "*") {
            result = Number(this.leftOperand) * Number(this.rightOperand);
        }
        else if(this.operator === "/") {
            result = Number(this.leftOperand) / Number(this.rightOperand);
        }
        return result;
    }
}
module.exports = Calculator;