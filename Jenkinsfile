pipeline {
    agent { docker { image 'mcr.microsoft.com/dotnet/core/sdk'}}

    stages {
        stage('Build and Test') {
        steps {
               dir("."){
                sh 'pwd'
                sh 'RUN apt-get update && apt-get install -y build-essential'
                sh 'make build'
              }
            }
        }

    }
}