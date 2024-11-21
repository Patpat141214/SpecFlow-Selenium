Feature: Hear Shout

A short summary of the feature

Scenario: Listener is within range
Given Lucy is located 15m from Sean
When Sean shouts "free bagels at Sean's"
Then Lucy hears Sean's message

Scenario: Listener hears a different message
Given Lucy is located 15m from Sean
When Sean shouts "Free Coffee!"
Then Lucy hears Sean's message

Scenario: Listener is different distance and shouts
Given Lucy is located 30m from Sean
When Sean shouts "Free keyboard"
Then Lucy hears Sean's message

