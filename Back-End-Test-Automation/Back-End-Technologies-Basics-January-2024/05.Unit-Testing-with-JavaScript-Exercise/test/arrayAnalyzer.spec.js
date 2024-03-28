import { analyzeArray } from "../src/arrayAnalyzer.js";
import { expect } from "chai";

describe('', () => {
    it('should return undefined when empty array is given', () => {
        //Arrange
        let input = []
        //Act
        let result = analyzeArray(input)
        //Assert
        expect(result).to.be.undefined
    });

    it('should return undefined when undefined value is given', () => {
        //Arrange
        let input = undefined
        //Act
        let result = analyzeArray(input)
        //Assert
        expect(result).to.be.undefined
    });

    it('should return undefined when given a string of some text', () => {
        //Arrange
        let input = 'text'
        //Act
        let result = analyzeArray(input)
        //Assert
        expect(result).to.be.undefined
    });

    it('should return undefined when given a string of numbers', () => {
        //Arrange
        let input = '1 2 3'
        //Act
        let result = analyzeArray(input)
        //Assert
        expect(result).to.be.undefined
    });

    it('should return correct values when single number array is given ', () => {
        //Arrange
        let input = [1]
        //Act
        let result = analyzeArray(input)
        //Assert
        expect(result).to.deep.equal({min: 1, max: 1, length: 1})
    });

    it('should return correct values when array with same numbers is given', () => {
        //Arrange
        let input = [1, 1]
        //Act
        let result = analyzeArray(input)
        //Assert
        expect(result).to.deep.equal({min: 1, max: 1, length: 2})
    });

    it('should return correct values when array with negative numbers is given', () => {
        //Arrange
        let input = [-1, -4]
        //Act
        let result = analyzeArray(input)
        //Assert
        expect(result).to.deep.equal({min: -4, max: -1, length: 2})
    });

    it('should return correct values when array with different numbers is given ', () => {
        //Arrange
        let input = [1, 2, 3]
        //Act
        let result = analyzeArray(input)
        //Assert
        expect(result).to.deep.equal({min: 1, max: 3, length: 3})
    });
});