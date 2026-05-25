using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MzansiPayrollSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace MzansiPayrollTests
{
    [TestClass]
    public class PayrollCalculatorTest
    {
        public TestContext TestContext { get; set; }

        //---------------------------------------------
        // This is the calculator object that all the tests share.
        // 'private' means only this class can use it.
        // '_calculator' follows the naming convention for private fields.
        private PayrollCalculator _calculator;

        [TestInitialize]
        public void BeforeEachTest()
        {
            // Create a fresh calculator object before each test
            _calculator = new PayrollCalculator();

            // Write a message to Test Explorer
            TestContext.WriteLine("Starting Test: " + TestContext.TestName);
        }

        //-------------------------------------------------------------
        // [TestCleanup] runs after each test completes.
        // We use it to clean up and reset everything.
        [TestCleanup]
        public void AfterEachTest()
        {
            // Log the completed test
            TestContext.WriteLine("Finished Test: " + TestContext.TestName);

            _calculator = null;
        }

        //-------------------------------------------------------------
        // TEST 1 — Gross Pay

        [TestMethod]
        [TestCategory("Unit Test")]
        public void GrossPay_40HoursWorked_ShouldReturnR38000()
        {
            // ARRANGE
            double hoursWorked = 40;
            double expectedGrossPay = 38000.00;

            // ACT
            double actualGrossPay =
                _calculator.CalculateGrossPay(hoursWorked);

            // ASSERT
            Assert.AreEqual(
                expectedGrossPay,
                actualGrossPay,
                0.01,
                "Gross Pay for 40 hours should be R3800.00"
            );

            // Display values in Test Explorer output
            TestContext.WriteLine($"Hours Worked: {hoursWorked}");
            TestContext.WriteLine($"Expected Gross Pay: R{expectedGrossPay:F2}");
            TestContext.WriteLine($"Actual Gross Pay: R{actualGrossPay:F2}");
        }

        //-------------------------------------------------------------
        // TEST 2 — UIF Deduction

        [TestMethod]
        [TestCategory("Unit Test")]
        public void UIF_GrossPayR38000_ShouldReturnR380()
        {
            // ARRANGE
            double grossPay = 38000.00;

            // Manual calculation:
            // 38000 × 0.01 = 380
            double expectedUIF = 380.00;

            // ACT
            double actualUIF =
                _calculator.CalculateUIFDeduction(grossPay);

            // ASSERT
            Assert.AreEqual(
                expectedUIF,
                actualUIF,
                0.01,
                "UIF should be 1% of gross pay: R380.00"
            );

            // Display values in Test Explorer output
            TestContext.WriteLine($"Gross Pay: R{grossPay:F2}");
            TestContext.WriteLine($"Expected UIF: R{expectedUIF:F2}");
            TestContext.WriteLine($"Actual UIF: R{actualUIF:F2}");
        }

        //-------------------------------------------------------------
        // TEST 3 — Membership Fee

        [TestMethod]
        [TestCategory("Unit Test")]
        public void MembershipFee_GrossPayR38000_ShouldReturnR4940()
        {
            // ARRANGE
            double grossPay = 38000.00;

            // Manual calculation:
            // 38000 × 0.13 = 4940
            double expectedFee = 4940.00;

            // ACT
            double actualFee =
                _calculator.CalculateMembershipFee(grossPay);

            // ASSERT
            Assert.AreEqual(
                expectedFee,
                actualFee,
                0.01,
                "Membership fee should be 13% of gross pay: R4940.00"
            );

            // Display values in Test Explorer output
            TestContext.WriteLine($"Gross Pay: R{grossPay:F2}");
            TestContext.WriteLine($"Expected Membership Fee: R{expectedFee:F2}");
            TestContext.WriteLine($"Actual Membership Fee: R{actualFee:F2}");
        }

        //-------------------------------------------------------------
        // TEST 4 — PAYE Deduction

        [TestMethod]
        [TestCategory("Unit Test")]
        public void PAYE_GrossR38000With2Dependents_ShouldReturnR8407_50()
        {
            // ARRANGE
            double grossPay = 38000.00;
            int numberOfDeps = 2;
            // Manual calculation:
            // Dependent rebate: 38000 × 0.0575 × 2 = 4370.00
            // Taxable income: 38000 - 4370 = 33630.00
            // PAYE: 33630 × 0.25 = 8407.50
            double expectedPAYE = 8407.50;
            // ACT
            double actualPAYE =
                _calculator.CalculatePAYEDeduction(grossPay, numberOfDeps);
            // ASSERT
            Assert.AreEqual(
                expectedPAYE,
                actualPAYE,
                0.01,
                "PAYE for R38000 gross with 2 dependents should be R8407.50"
            );
            // Log the full working so we can see each step
            TestContext.WriteLine($"Gross Pay: R{grossPay:F2}");
            TestContext.WriteLine($"Dependents: {numberOfDeps}");
            TestContext.WriteLine($"Dependent Rebate: R{(grossPay * 0.0575 * numberOfDeps):F2}");
            TestContext.WriteLine($"Taxable Income: R{(grossPay - (grossPay * 0.0575 * numberOfDeps)):F2}");
            TestContext.WriteLine($"Expected PAYE: R{expectedPAYE:F2}");
            TestContext.WriteLine($"Actual PAYE: R{actualPAYE:F2}");

        }
        //-------------------------------------------------------------
        // TEST 5 — Net Pay Calculation

        [TestMethod]
        [TestCategory("Unit Test")]

        public void NetPay_AllDeductions_ShouldReturnR24272_50()
        {
            // ARRANGE
            // For Net we already the individual amounts.
            // We the values from our manual calcalation of the previous tests.
            double grossPay = 38000.00;
            double uif = 380.00; // From Test 2
            double paye = 8407.50; // From Test 3
            double membershipFee = 4940.00; // From Test 4
            // Manual calculation:
            // Net Pay = Gross Pay - UIF - PAYE - Membership Fee
            // Net Pay = 38000 - 380 - 8407.50 - 4940 = 24272.50
            double expectedNetPay = 24272.50;

            // ACT
            // CalculatedNetPAy takes all four values as seperate inputs
            double actualNetPay =
                _calculator.CalculateNetPay(grossPay, uif, paye, membershipFee);
            // ASSERT
            Assert.AreEqual(
                expectedNetPay,
                actualNetPay,
                0.01,
                "Net Pay should be R24272.50 after all deductions"
            );
            // Show the full calculation summary in the Test Explorer output
            TestContext.WriteLine("=== Net Pay Calculation Summary ===");
            TestContext.WriteLine($"Gross Pay: R{grossPay:F2}");
            TestContext.WriteLine($"UIF (-): R{uif:F2}");
            TestContext.WriteLine($"PAYE (-): R{paye:F2}");
            TestContext.WriteLine($"Membership Fee (-): R{membershipFee:F2}");
            TestContext.WriteLine("-----------------------------------");
            TestContext.WriteLine($"Expected Net Pay: R{expectedNetPay:F2}");
            TestContext.WriteLine($"Actual Net Pay: R{actualNetPay:F2}");

        }

        // --------------------------------------------------
        // INTEGRATION TEST
        // This test calls ALL methods in sequence,
        // just like the Calculate button does.
        // It checks that the methods work TOGETHER correctly.
        // --------------------------------------------------

        [TestMethod]
        [TestCategory("Integration")]
        public void FullPayroll_40Hours2Dependents_AllValuesCorrect()
        {
            // ARRANGE: start from raw user inputs only
            double hoursWorked = 40;
            int dependents = 2;

            // ACT: call each method in sequence
            // (same order as the Calculate button)

            double grossPay =
                _calculator.CalculateGrossPay(hoursWorked);

            double uif =
                _calculator.CalculateUIFDeduction(grossPay);

            double paye =
                _calculator.CalculatePAYEDeduction(grossPay, dependents);

            double membership =
                _calculator.CalculateMembershipFee(grossPay);

            double netPay =
                _calculator.CalculateNetPay(
                    grossPay,
                    uif,
                    paye,
                    membership
                );

            // ASSERT: check EACH result
            // This confirms the whole chain works together

            Assert.AreEqual(
                38000.00,
                grossPay,
                0.01,
                "Gross pay incorrect"
            );

            Assert.AreEqual(
                380.00,
                uif,
                0.01,
                "UIF incorrect"
            );

            Assert.AreEqual(
                8407.50,
                paye,
                0.01,
                "PAYE incorrect"
            );

            Assert.AreEqual(
                4940.00,
                membership,
                0.01,
                "Membership incorrect"
            );

            Assert.AreEqual(
                24272.50,
                netPay,
                0.01,
                "Net pay incorrect"
            );

            // Log the complete payroll chain

            TestContext.WriteLine("=== INTEGRATION TEST: FULL PAYROLL CHAIN ===");

            TestContext.WriteLine(
                $"Input: {hoursWorked} hours, {dependents} dependents"
            );

            TestContext.WriteLine($"Gross Pay:      R{grossPay:F2}");
            TestContext.WriteLine($"UIF:            R{uif:F2}");
            TestContext.WriteLine($"PAYE:           R{paye:F2}");
            TestContext.WriteLine($"Membership:     R{membership:F2}");
            TestContext.WriteLine($"Net Pay:        R{netPay:F2}");
        }
    }

   }