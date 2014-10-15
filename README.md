ScriptCs.Fixie
==============

Script Pack to use the [Fixie test runner](http://fixie.github.io/) from ScriptCs

## Installation

In the same folder as the .csx file you're writing, run

	scriptcs -install scriptcs.fixie
	
## Usage

```
var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 
```

Fixie is a convention-based test framework that, by default, runs all public methods in any class ending with the word 'Tests'

Note! Neither Fixie nor this Script Pack includes an assertion library. You will need to install your favorite and import it separately.


### Example

```
#r "Shouldly.dll"
using Shouldly;

public class SomeTests
{
	public void Add()
	{
		1.ShouldBe(1);
	}
}

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 
```
