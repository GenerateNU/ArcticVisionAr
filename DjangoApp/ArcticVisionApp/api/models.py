from django.db import models
from django.contrib.auth.models import User

# Create your models here.
class ArcticVisiomUser(models.Model):
    user = models.OneToOneField(User)
    phone = models.CharField(max_length=15)
    friends = models.ManyToManyField(User)

