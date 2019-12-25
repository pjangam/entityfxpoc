.PHONY: all
all: test

.PHONY: test
test:clean
test:
	dotnet test

.PHONY: build
build:clean
build:
	dotnet build

.PHONY: clean
clean:
	dotnet clean