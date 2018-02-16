package com.softuni.entity;

import org.codehaus.groovy.util.StringUtil;

import static jdk.nashorn.internal.objects.Global.NaN;

public class Calculator {
    private double leftOperand;
    private double rightOperand;
    private String operator;

    public double getLeftOperand() {
        return leftOperand;
    }

    public void setLeftOperand(double leftOperand) {
        this.leftOperand = leftOperand;
    }

    public double getRightOperand() {
        return rightOperand;
    }

    public void setRightOperand(double rightOperand) {
        this.rightOperand = rightOperand;
    }

    public String getOperator() {
        return operator;
    }

    public void setOperator(String operator) {
        this.operator = operator;
    }
    public Calculator (double leftOperand, double rightOperand, String operator) {
        this.leftOperand = leftOperand;
        this.rightOperand = rightOperand;
        this.operator = operator;
    }
    public double calculateResult() {
       double result;
        if (this.operator.equals("+")) {
            result = this.leftOperand + this.rightOperand;
            if (result == NaN) {
                result = 0;
            }
        }
        else if (this.operator.equals("-")) {
            result = this.leftOperand - this.rightOperand;
            if (result == NaN) {
                result = 0;
            }
        }
        else if (this.operator.equals("*")) {
            result = this.leftOperand * this.rightOperand;
            if (result == NaN) {
                result = 0;
            }
        }
        else if (this.operator.equals("^")) {
            result = Math.pow(this.leftOperand, this.rightOperand);
            if (result == NaN) {
                result = 0;
            }
        }
        else {
            result = this.leftOperand / this.rightOperand;
            if (result == NaN) {
                result = 0;
            }
        }

        return  result;
    }
}
