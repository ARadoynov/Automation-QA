import { createCalculator } from '../src/add-substract.js';
import { assert, expect } from 'chai';

describe('createCalculator', () => {
    it('should return 0 if no numbers are executed on the calculator', () => {
        //Arrange
        const calculator = createCalculator()
        //Act
        const result = calculator.get()
        //Assert
        expect(result).to.equals(0)
    });

    it('should return a negative number if only substarct functions are executed', () => {
        //Arrange
        const calculator = createCalculator()
        calculator.subtract(5)
        calculator.subtract(10)
        //Act
        const result = calculator.get()
        //Assert
        expect(result).to.equals(-15)
    });

    it('should return a postivie number if only add functions are executed', () => {
        //Arrange
        const calculator = createCalculator()
        calculator.add(5)
        calculator.add(10)
        //Act
        const result = calculator.get()
        //Assert
        expect(result).to.equals(15)
    });

    it('should return a postivie number if only add functions are executed', () => {
        //Arrange
        const calculator = createCalculator()
        calculator.add(5)
        calculator.add(10)
        //Act
        const result = calculator.get()
        //Assert
        expect(result).to.equals(15)
    });

    it('should return calculated result when given only numbers as string', () => {
         //Arrange
         const calculator = createCalculator()
         calculator.add('5')
         calculator.add('10')
         //Act
         const result = calculator.get()
         //Assert
         expect(result).to.equals(15)
    });

    it('should handle a mix of operations', () => {
         //Arrange
         const calculator = createCalculator()
         calculator.add(5)
         calculator.add('10')
         //Act
         const result = calculator.get()
         //Assert
         expect(result).to.equals(15)
    });

});