FROM jenkins/jenkins:lts

# install jenkins plugins
COPY ./plugins /usr/share/jenkins/plugins
RUN while read i ; \
		do /usr/local/bin/install-plugins.sh $i ; \
	done < /usr/share/jenkins/plugins
User root
RUN apt-get update && apt-get install -y build-essential


# allows to skip Jenkins setup wizard
ENV JAVA_OPTS -Djenkins.install.runSetupWizard=false

# volume for Jenkins settings
VOLUME /var/jenkins_home
VOLUME /var/run/docker.sock
VOLUME /usr/bin/docker
VOLUME /home
