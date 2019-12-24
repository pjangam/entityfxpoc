.PHONY: all
all: test

.PHONY: test
test:
	dotnet test

.PHONY: build
build:
	dotnet build