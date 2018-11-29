Feature: SpecFlowFeature1

Scenario: Scenario 1 to check parallelism
Given Getting with delay of '5' seconds
When Something happens for '1' second
Then Executed for '6' seconds

Scenario: Scenario 2 to check parallelism
Given Getting with delay of '2' seconds
When Something happens for '3' second
Then Executed for '2' seconds