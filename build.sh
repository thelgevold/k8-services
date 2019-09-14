#helm init
#helm install stable/nginx-ingress --name nginx-ingress --namespace default --set controller.service.loadBalancerIP=127.0.0.1 --set controller.scope.enabled=true --set controller.scope.namespace="default"

docker build -f Dockerfile-greetings -t greeting-service:v6 .
docker build -f Dockerfile-cars -t car-service:v6 .
docker build -f Dockerfile-friends -t friend-service:v6 .

kubectl apply -f greetings.yml
kubectl apply -f cars.yml
kubectl apply -f friends.yml

kubectl apply -f ingress.yml