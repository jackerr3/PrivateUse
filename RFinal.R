install.packages("UsingR")
View(mtcars)
mydata = mtcars
typeof(mydata)
mydata
makes <- as.factor(c("Mazda", "Mazda", "Datsun", "AMC", "AMC", "Plymouth", "Plymouth", "Mercedes", 
                     "Mercedes", "Mercedes", "Mercedes", "Mercedes", "Mercedes", "Mercedes", "Cadillac",
                     "Lincoln", "Chrysler", "Fiat", "Honda", "Toyota", "Toyota", "Dodge", "AMC",
                     "Camaro", "Pontiac", "Fiat", "Porsche", "Lotus", "Ford", "Ferrari", "Maserati",
                     "Volvo"))

mydata <- data.frame(mydata, makes)
attach(mydata)
summary(fit<-aov(hp~makes))
test<-TukeyHSD(aov(hp~makes))
mean(hp)
German<- subset(mydata, makes == "Mercedes" | makes == "Porsche")
mean(subset(mydata, makes == "Ford")$hp)
mean(subset(mydata, makes == "Ford" || makes == 'Dodge')$hp)
american <- mydata[ which(makes=='Ford' | makes == "Dodge" | makes == "AMC" | makes == "Plymouth" | 
                            makes == "Chrysler" | makes == "Lincoln"| makes == "Cadillac"| makes == "Camaro" | makes == "Pontiac"),]
mean(american$hp)
mean(German$hp)
length(american)
length(German)
#surprisingly enough, The amount of german and american cars are almost exactly the same, so we can perform a simple t-test to compare means of several columns
t.test(american$hp, German$hp)
t.test(american$mpg * american$wt, German$hp * German$wt)
t.test(american$qsec, German$qsec)
#american quarter mile times are faster than german in this data set, but not statistically significantly at the .05 level

#new data set with only american and german cars, for simplicity
amer.germ <- mydata[ which(makes=='Ford' | makes == "Dodge" | makes == "AMC" | makes == "Plymouth" | 
                           makes == "Chrysler" | makes == "Lincoln"| makes == "Cadillac"| makes == "Camaro" | makes == "Pontiac" |
                           makes == "Mercedes" | makes == "Porsche"),]
amer.germ$makes <- droplevels(amer.germ$makes)
detach(mydata)
attach(amer.germ)
detach(amer.germ)
plot(amer.germ$qsec~amer.germ$makes, main="Quarter Mile Data")
plot(amer.germ$hp~amer.germ$makes, main="Horsepower Data")
plot(amer.germ$mpg~amer.germ$makes, main="Fuel Efficiency Data")
View(amer.germ)
